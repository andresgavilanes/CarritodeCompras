<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="CarritodeCompras.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>RegistrationForm_v10 by Colorlib</title>
		<meta name="viewport" content="width=device-width, initial-scale=1.0">

		<!-- LINEARICONS -->
		<link rel="stylesheet" href="fonts/linearicons/style.css">
		
		<!-- STYLE CSS -->
		<link rel="stylesheet" href="css/style.css">
</head>
<body>
	
  
       <div class="wrapper">
			<div class="inner">
				<%--<img src="Imagenes/images/image-1.png" alt="" class="image-1">--%>
				<form runat="server">
					<h3> Productos</h3>
                    <asp:Panel ID="Panel1" runat="server" Height="278px">
						<div>
                            <asp:Label ID="lbl_pnombre" runat="server" Text="Nombre"></asp:Label>
						</div>
					<div class="form-holder">
						
						<span class="lnr lnr-store"></span>
                        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>

					</div>
					<div>
                            <asp:Label ID="lbl_pdescripcion" runat="server" Text="Descripcion"></asp:Label>
						</div>
					<div class="form-holder">
						
						<span class="lnr lnr-dice"></span>
                        <asp:TextBox ID="txt_descripcion" runat="server"></asp:TextBox>

					</div>
					<div>
						<div>
                            <asp:Label ID="lbl_Precio" runat="server" Text="Precio"></asp:Label>
						</div>
					<div class="form-holder">
						<span class="lnr lnr-plus-circle"></span>
                        <asp:TextBox ID="txt_precio" runat="server"></asp:TextBox>

					</div>
					<div>
                            <asp:Label ID="lbl_categoria" runat="server" Text="Categoria"></asp:Label>
						</div>
						<div class="form-holder">
						
                       <asp:DropDownList ID="ddl_categoria" runat="server" ></asp:DropDownList>
                        </div>
						<div>
                            <asp:Label ID="lbl_imagen" runat="server" Text="Imagen"></asp:Label>
						</div>
						<div class="form-holder">
                        <asp:Image ID="img" runat="server" />

                    </asp:Panel>
                    <asp:Panel ID="Panel2" runat="server">
                        <asp:Table ID="Table1" runat="server" Height="25px" Width="373px">

                        </asp:Table>
						<table class="table-secondary">
							<thead>
    <tr>
      <span class="lnr lnr-estrella"></span><th scope="col">Nuevo</th>
      <span class="lnr lnr-pencil"></span> <th scope="col">Grabar</th>
      <span class="lnr lupa-lnr"></span><th scope="col">Buscar</th>
      
    </tr>
  </thead>
  
						</table>

                    </asp:Panel>
                  </form>
					
                            
					
			
		</div>
		
		<script src="js/jquery-3.3.1.min.js"></script>
		<script src="js/main.js"></script>

</body>

</html>
