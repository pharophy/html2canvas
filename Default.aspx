﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BjxFeedback._Default" %>

<%@ Register src="SubmitFeedback.ascx" tagname="SubmitFeedback" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>test</title>
    <link href="css/feedback.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        hello world
    </div>
    <uc1:SubmitFeedback ID="SubmitFeedback1" runat="server" />
    </form>
</body>
</html>
