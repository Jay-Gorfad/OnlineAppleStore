<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="OnlineAppleStore.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Order Successful</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
        }
        .container {
            max-width: 800px;
            margin: 50px auto;
            text-align: center;
            padding: 40px;
            border-radius: 10px;
            background-color: #fff;
            box-shadow: 0px 0px 10px 0px rgba(0, 0, 0, 0.1);

        }
        h1 {
            color: #333;
        }
        p {
            font-size: 18px;
            margin-bottom: 20px;
        }
        .checkmark {
            display: inline-block;
            width: 100px;
            height: 100px;
            border-radius: 50%;
            background-color: #4CAF50;
            line-height: 100px;
            color: white;
            font-size: 60px;
            margin-bottom: 20px;
        }
        .footer {
            position: fixed;
            left: 0;
            bottom: 0;
            width: 100%;
            background-color: #333;
            color: #fff;
            text-align: center;
            padding: 10px 0;
        }
    </style>
</head>
<body>
    <br />
    <div class="container">
        <div class="checkmark">&#10004;</div>
        <h1>Order Successful</h1>
        <p>Your order has been placed successfully. Thank you for shopping with us!</p>
    </div>
    <br />
    <br />
</body>
</html>

</asp:Content>

