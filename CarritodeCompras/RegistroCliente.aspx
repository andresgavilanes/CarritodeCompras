<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="CarritodeCompras.RegistroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


	<html>
	
		<meta charset="utf-8">
		<title>RegistrationForm_v10 by Colorlib</title>
		<meta name="viewport" content="width=device-width, initial-scale=1.0">

		<!-- LINEARICONS -->
		<link rel="stylesheet" href="fonts/linearicons/style.css">
		
		<!-- STYLE CSS -->
		<link rel="stylesheet" href="css/style.css">
	</head>

			<form runat="server">
	<body>
	
		
		<div class="wrapper">
			<div class="inner">
				<%--<img src="Imagenes/images/image-1.png" alt="" class="image-1">--%>
				<form action="">
					<h3>Nuevo Registro</h3>
					<div>
                            <asp:Label ID="lbl_cedula" runat="server" Text="Cedula"></asp:Label>
						</div>
					<div class="form-holder">
						
						<span class="lnr lnr-user"></span>
                        <asp:TextBox ID="txt_cedula" runat="server"></asp:TextBox>

					</div>
					<div>
                            <asp:Label ID="lbl_nombres" runat="server" Text="Nombres"></asp:Label>
						</div>
					<div class="form-holder">
						
						<span class="lnr lnr-user"></span>
                        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>

					</div>
					<div>
                            <asp:Label ID="lbl_apellidos" runat="server" Text="Apellidos"></asp:Label>
						</div>
					
					<div class="form-holder">
						
						<span class="lnr lnr-user"></span>
                        <asp:TextBox ID="txt_apellidos" runat="server"></asp:TextBox>

					</div>
					<div>
                            <asp:Label ID="lbl_direccion" runat="server" Text="Direccion"></asp:Label>
						</div>
					<div class="form-holder">
						
						<span class="lnr lnr-home"></span>
                        <asp:TextBox ID="txt_direccion" runat="server"></asp:TextBox>

					</div>
					<div>
                            <asp:Label ID="lbl_tlf" runat="server" Text="Telefono"></asp:Label>
						</div>
					<div class="form-holder">
						<span class="lnr lnr-phone-handset"></span>
						<asp:TextBox ID="txt_tlf" runat="server"></asp:TextBox>
					</div>
					<div>
                            <asp:Label ID="lbl_correo" runat="server" Text="Correo"></asp:Label>
						</div>
					<div class="form-holder">
						<span class="lnr lnr-envelope"></span>
						<asp:TextBox ID="txt_correo" runat="server"></asp:TextBox>
					</div>
					<div>
                            <asp:Label ID="lbl_usuario" runat="server" Text="Usuario"></asp:Label>
						</div>
					<div class="form-holder">
						<span class="lnr lnr-user"></span>
						<asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
					</div>
					<div>
                            <asp:Label ID="lbl_clave" runat="server" Text="Contraseña"></asp:Label>
						</div>
					<div class="form-holder">
						<span class="lnr lnr-lock"></span>
						<asp:TextBox  typu="password" ID="txt_" runat="server"></asp:TextBox>
					</div>
					<button>
                        <asp:Button ID="btn_registrar" runat="server" Text="Registrarse" OnClick="btn_registrar_Click" />
						
					</button>
				</form>
				
				<img src="Imagenes/images/image-2.png" alt="" class="image-2">
			</div>
			
		</div>
		
		<script src="js/jquery-3.3.1.min.js"></script>
		<script src="js/main.js"></script>
	</body><!-- This templates was made by Colorlib (https://colorlib.com) -->
				</form>
</html>
