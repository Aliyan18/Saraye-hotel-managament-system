<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="events.aspx.cs" Inherits="WebApplication4.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: sans-serif;
            background: url('download.jpg') no-repeat center center fixed;
            background-size: cover;
            background-repeat: no-repeat;
            margin: 0;
            padding: 0;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
            font-size: 17px;
        }

        form {
            background-color: #000000;
            padding: 20px;
            border-radius: 10px;
            margin: 20px auto;
            width: 50%;
        }

        h2 {
            font-family: sans-serif;
            text-align: center;
            color: #ff7200;
            font-size: 25px;
            background-color: #fff;
            border-radius: 10px;
            margin: 0 auto 20px;
            padding: 8px;
        }

        label {
            display: block;
            margin-bottom: 10px;
            color:  #fff;
        }

        input[type="text"],
        input[type="date"],
        input[type="number"] {
            width: 97%;
            padding: 10px;
            margin-bottom: 20px;
            border: 2px solid #ff7200;
            border-radius: 5px;
        }

        input[type="submit"] {
            width: 100%;
            padding: 10px;
            background-color:  #ff7200;
            color: #fff;
            border: none;
            border-radius: 10px;
            font-size: 18px;
            cursor: pointer;
            transition: 0.4s ease;
        }

        input[type="submit"]:hover {
            background-color: #fff;
            color: #ff7200; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">




        <h2>Event Scheduler</h2><br>

        <label for="event_name">Event Name:</label>
        <asp:textbox runat="server" type="text" id="event_name" name="event_name" ></asp:textbox>

        <label for="event_date">Event Date:</label>
        <asp:textbox runat="server" type="date" id="event_date" name="event_date" ></asp:textbox>

        <label for="event_location">Location:</label>
        <asp:textbox runat="server" type="text" id="event_location" name="event_location" ></asp:textbox>

        <label for="event_capacity">Capacity:</label>
        <asp:textbox runat="server" type="number" id="event_capacity" name="event_capacity" ></asp:textbox>

        <label for="event_organizer">Organizer:</label>
        <asp:textbox runat="server" type="text" id="event_organizer" name="event_organizer" ></asp:textbox>
        <br><br>
        <asp:button runat="server" type="submit" Text="Add Event" onclick="Unnamed1_TextChanged"></asp:button>

    </form>
</body>
</html>
