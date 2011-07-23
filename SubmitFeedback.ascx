<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SubmitFeedback.ascx.cs" Inherits="BjxFeedback.SubmitFeedback" %>
<asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
    <Scripts>
        <asp:ScriptReference Path="~/Scripts/jquery-1.4.1.min.js" />
        <asp:ScriptReference Path="~/Scripts/html2canvas.js" />
        <asp:ScriptReference Path="~/Scripts/jsfeedback.js" />
        <asp:ScriptReference Path="~/Scripts/FeedbackEvents.js" />
    </Scripts>
</asp:ScriptManagerProxy>
<div id="feedback">send feedback</div>