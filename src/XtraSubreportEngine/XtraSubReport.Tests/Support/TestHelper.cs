﻿using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using NorthwindOData;
using NUnit.Framework;
using XtraSubreport.Contracts.DesignTime;
using XtraSubreport.Contracts.RuntimeActions;
using XtraSubreport.Designer;
using XtraSubreport.Engine;
using XtraSubreport.Engine.Designer;
using XtraSubreport.Engine.RuntimeActions;
using XtraSubreportEngine.Support;

namespace XtraSubReport.Tests
{
    static class TestHelper
    {
        public static IDesignerContext CreateDesignerContext()
        {
            var datasourcelocator = CreateDataSourceLocator();
            return new DummyDesignerContext(datasourcelocator);
        }

        public static DataSourceLocator CreateDataSourceLocator()
        {
            var providers = new List<IReportDatasourceProvider>() { new NorthwindDatasourceProvider() };
            return new DataSourceLocator(providers);
        }

        public static TReport RunThroughSerializer<TReport>(TReport report)
            where TReport : XtraReport
        {
            var stream = new MemoryStream();

            report.SaveLayout(stream);

            stream.Position = 0;

            var report2 = XtraReport.FromStream(stream, true);

            return (TReport)report2;
        }

        public static DesignTimeDataSourceDefinition NorthwindDataSource
        {
            get { return new DesignTimeDataSourceDefinition(new NorthwindOrders().UniqueId, "Northwind_Orders", string.Empty); }
        }

        public static object GetNorthwindOrders()
        {
            var locator = CreateDataSourceLocator();
            return locator.GetDataSource(NorthwindDataSource);
        }

        public static Tuple<MyReportBase, XRSubreport, MyReportBase, IDesignerContext> GetParentAndNestedSubreport()
        {
            var factory = new ReportFactory();

            // Parent Report
            var parentReport = factory.GetNewReport("parentReport");

            // Subreport
            var subreport = factory.GetNewReport("subreport");

            // Order-Details Band
            var detailReport = new DetailReportBand() { DataMember = "Order_Details" };
            var detailBand = new DetailBand();
            parentReport.Bands.Add(detailReport);
            detailReport.Bands.Add(detailBand);

            // Insert Subreport into Subreport Container... for Runtime Testing
            var subreportContainer = new XRSubreport() { ReportSource = subreport };
            detailBand.Controls.Add(subreportContainer);

            // Datasource MUST be set AFTER the Detail Band has been added!!  Otherwise detailband gets empty object[] as its datasource
            var designContext = TestHelper.CreateDesignerContext();
            parentReport.ChangeDesignTimeDatasource(TestHelper.NorthwindDataSource, designContext);
            Assert.IsNotNull(parentReport.DataSource);

            return new Tuple<MyReportBase, XRSubreport, MyReportBase, IDesignerContext>(parentReport, subreportContainer, subreport, designContext);
        }

        public static void RunReport(XtraReport report, params IReportRuntimeAction[] action)
        {
            var controller = new XRReportController(report, new XRRuntimeActionFacade(action));
            controller.Print(r => r.ExportToHtml(new MemoryStream(), new HtmlExportOptions()));
        }


    }
}
