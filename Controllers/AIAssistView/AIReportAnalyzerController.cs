#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.AIAssistView
{
    public partial class AIAssistViewController : Controller
    {
        public List<ToolbarItemModel> ReportAnalyzerItems = new List<ToolbarItemModel>();
        public ActionResult AIReportAnalyzer()
        {
            ReportAnalyzerItems.Add(new ToolbarItemModel { align = "Right", iconCss = "e-icons e-refresh" });
            ViewData["ToolbarItems"] = ReportAnalyzerItems;
            ViewData["PromptResponseData"] = new PromptResponseData().GetReportAnalyzerPromptResponseData();
            ViewData["PromptSuggestionData"] = new PromptResponseData().GetReportAnalyzerSuggestionData();
            return View();
        }
    }
}