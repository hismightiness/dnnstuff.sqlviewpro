
using System.Web.UI.HtmlControls;
using System;
using System.Diagnostics;
using System.Data;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
using System.Collections;
using System.Web.UI;
using System.Web;
using DotNetNuke.UI.UserControls;




//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DNNStuff.SQLViewPro.SSRSReports
{
	
	public partial class SSRSReportSettingsControl
	{
		
		///<summary>
		///lblProcessingMode control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblProcessingMode;
		
		///<summary>
		///ddlProcessingMode control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.DropDownList ddlProcessingMode;
		
		///<summary>
		///pnlRemote control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.HtmlControls.HtmlGenericControl pnlRemote;
		
		///<summary>
		///lblReportServerUrl control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblReportServerUrl;
		
		///<summary>
		///txtReportServerUrl control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtReportServerUrl;
		
		///<summary>
		///lblReportServerReportPath control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblReportServerReportPath;
		
		///<summary>
		///txtReportServerReportPath control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtReportServerReportPath;
		
		///<summary>
		///lblReportServerUsername control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblReportServerUsername;
		
		///<summary>
		///txtReportServerUsername control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtReportServerUsername;
		
		///<summary>
		///lblReportServerPassword control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblReportServerPassword;
		
		///<summary>
		///txtReportServerPassword control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtReportServerPassword;
		
		///<summary>
		///lblReportServerDomain control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblReportServerDomain;
		
		///<summary>
		///txtReportServerDomain control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtReportServerDomain;
		
		///<summary>
		///pnlLocal control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.HtmlControls.HtmlGenericControl pnlLocal;
		
		///<summary>
		///lblLocalReportPath control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblLocalReportPath;
		
		///<summary>
		///urlLocalReportPath control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected UrlControl urlLocalReportPath;
		
		///<summary>
		///lblAdditionalParameters control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblAdditionalParameters;
		
		///<summary>
		///txtAdditionalParameters control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtAdditionalParameters;
		
		///<summary>
		///lblViewerWidth control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblViewerWidth;
		
		///<summary>
		///txtViewerWidth control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtViewerWidth;
		
		///<summary>
		///lblViewerHeight control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblViewerHeight;
		
		///<summary>
		///txtViewerHeight control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.TextBox txtViewerHeight;
		
		///<summary>
		///lblReportOptions control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected LabelControl lblReportOptions;
		
		///<summary>
		///lstReportOptions control.
		///</summary>
		///<remarks>
		///Auto-generated field.
		///To modify move field declaration from designer file to code-behind file.
		///</remarks>
		protected System.Web.UI.WebControls.CheckBoxList lstReportOptions;
	}
}

