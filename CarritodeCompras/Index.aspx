<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CarritodeCompras.Index" %>

<!DOCTYPE html>

<head>
	<title>Login V9</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="Imagenes/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
<!--===============================================================================================-->
</head>
<body>
	
	
	<div class="container-login100" style="background-image: url('Imagenes/icons/fondo.jpg');">
		<div class="wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30">
			<form class="login100-form validate-form">
				<center>
					<img src="Imagenes/icons/login.jpg"  class="login100-social-item img" alt="GOOGLE">
					</center>
				<span class="login100-form-title p-b-37">
					Login
				</span>
				<form runat= "server">
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
					<ContentTemplate>
						<asp:Label ID="Label1" runat="server" Text="Usuario" class="wrap-input100 validate-input m-b-20"></asp:Label>
				<div class="wrap-input100 validate-input m-b-20" data-validate="Ingrese su cédula">
                   <asp:TextBox ID="txt_Cedula" class="input100"  placeholder="Ingrese su cédula" runat="server"></asp:TextBox>
					<span class="focus-input100"></span>
				</div>
             	<asp:Label ID="Label3" runat="server" Text="Contraseña" class="wrap-input100 validate-input m-b-20"></asp:Label>
				<div class="wrap-input100 validate-input m-b-25" data-validate = "Enter password">
					<asp:TextBox ID="txt_pass" runat="server" class="input100" placeholder="Ingrese su password" TextMode="Password"></asp:TextBox>
					<span class="focus-input100"></span>
				</div>
					

				<div class="container-login100-form-btn">
                    <asp:Button ID="btn_ingresar" runat="server" class="login100-form-btn" Text="Ingresar" />
					 <asp:Button ID="btn_olvido" Visible="false" runat="server" class="login100-form-btn" Text="Recuperar Clave" />		
			    </div>
						<%--<div>
				     <asp:LinkButton ID="lnk_olvido"  class="txt2 hov1" runat="server" OnClick="lnk_olvido_Click">Olvido su contraseña</asp:LinkButton>
					<br />    
					<asp:LinkButton ID="lnk_regresar"  Visible="false" class="txt2 hov1" runat="server" OnClick="lnk_regresar_Click" PostBackUrl="~/Login.aspx">Regresar</asp:LinkButton>
					<br />
                    <asp:LinkButton ID="lnkregistrar" class="txt2 hov1" OnClick="lnkregistrar_Click" runat="server" EnableTheming="True" PostBackUrl="~/Registro.aspx">Crear una Cuenta!</asp:LinkButton>
				</div>--%>					
						</ContentTemplate>
						</asp:UpdatePanel>
						</form>
				<div>
                    <asp:Label ID="lbl_intento" Visible="false" runat="server" Text="Intentos"></asp:Label>
					<br />
                    <asp:Label ID="lbl_mensaje"  ForeColor="Red" runat="server" Text=""></asp:Label>
				</div>
			</form>
				

			
		</div>
	</div>
	
	



</body>


</html>
