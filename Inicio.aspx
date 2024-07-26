<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="RegaloLaura.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .wrapper {
            display: flex;
            height:550px;
            justify-content: center;
            align-items: center;
            text-align:center;
        }
        .contenedor{
            font-family: cursive;
            display:flex;
            padding: 20px;
            width: 400px;
            height:auto;
            border-radius: 10px;
            margin-right: 5%;
            text-align:center;
            align-items:center;
            flex-direction:column;
            background-color:white;
        }
        .boton{
            border:none;
            margin-top:10px;
            margin-bottom:10px;
            background-color:#00bdff;
            width: 100px;
            height:30px;
            color: white;
            border-radius:50px;
            text-align:center;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }
        .boton:hover {
            background-color: #00bdff;
        }
        .caja{
            margin-top:10px;
            border: none;
            border-bottom: 2px solid #00bdff;
            outline: none;
            padding: 8px;
            background: transparent;
            color:black;
        }
        img{
            width:150px;
            height:auto;

        }
        .label-pequeño {
            display: block;
            margin-top: 10px;
            font-family: cursive;
            color: #00bdff;
            font-size: 14px;
            background: transparent;
            padding: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <div class="contenedor">
            <h3>Contraseña</h3>
            <asp:Label ID="error" runat="server" CssClass="label-pequeño"></asp:Label>
            <asp:TextBox ID="contraseña" runat="server" Placeholder="Contraseña" CssClass="caja" TextMode="Password"></asp:TextBox>
            <asp:Button ID="boton" runat="server" Text="Login" CssClass="boton" OnClick="boton_Click" ></asp:Button>
            <asp:Label ID="pista" runat="server" CssClass="label-pequeño"></asp:Label>
        </div>
    </div>
</asp:Content>
