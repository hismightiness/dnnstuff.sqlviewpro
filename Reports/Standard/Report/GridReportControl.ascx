<%@ Control Language="C#" Inherits="DNNStuff.SQLViewPro.StandardReports.GridReportControl" CodeBehind="GridReportControl.ascx.cs" AutoEventWireup="true" Explicit="True" targetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<asp:panel id="pnlHeader" Runat="server"></asp:panel>
<asp:DataGrid id="dgCommand" runat="server" Width="100%" EnableViewState="true" AutoGenerateColumns="false" 
    OnPageIndexChanged="PageIndexChanged" 
    OnSortCommand="SortCommand_OnClick"
    OnItemCreated="dgCommand_ItemCreated"
    OnItemCommand="dgCommand_ItemCommand" />
<asp:panel id="pnlFooter" Runat="server"></asp:panel>

