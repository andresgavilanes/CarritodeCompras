<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro Empleados.aspx.cs" Inherits="CarritodeCompras.Registro_Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

	
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
					<h3> Registro Empleados</h3>
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
                        <asp:Label ID="lbl_cargo" runat="server" Text="Cargo"></asp:Label>
					</div>
					<div class="form-holder">
						
                       <asp:DropDownList ID="ddl_cargo" runat="server" ></asp:DropDownList>
                        </div>
					
					   <asp:Button ID="btn_RegristroEmple" runat="server" Text="Registrar" />
				</form>
             
				<img src="Imagenes/images/emple.jpg" alt="" class="emple">
			</div>
			
		</div>
		
		<script src="js/jquery-3.3.1.min.js"></script>
		<script src="js/main.js"></script>
	</body><!-- This templates was made by Colorlib (https://colorlib.com) -->
				</form>
</html>
