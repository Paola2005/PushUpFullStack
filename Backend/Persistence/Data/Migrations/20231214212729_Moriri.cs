using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class Moriri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carritos_Usuarios_UsuarioId",
                table: "Carritos");

            migrationBuilder.DropForeignKey(
                name: "FK_Detallescarritos_Carritos_CarritoId",
                table: "Detallescarritos");

            migrationBuilder.DropForeignKey(
                name: "FK_Detallescarritos_Productos_ProductoId",
                table: "Detallescarritos");

            migrationBuilder.DropForeignKey(
                name: "FK_Detallespedidos_Pedidos_PedidoId",
                table: "Detallespedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Detallespedidos_Productos_ProductoId",
                table: "Detallespedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Detallestransaccions_Productos_ProductoId",
                table: "Detallestransaccions");

            migrationBuilder.DropForeignKey(
                name: "FK_Detallestransaccions_Transacciones_TransaccionId",
                table: "Detallestransaccions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventarios_Productos_ProductoId",
                table: "Inventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Usuarios_UsuarioId",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Transacciones_Usuarios_UsuarioId",
                table: "Transacciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarioscompras_Usuarios_UsuarioId",
                table: "Usuarioscompras");

            migrationBuilder.DropForeignKey(
                name: "userrol_ibfk_1",
                table: "userrol");

            migrationBuilder.DropForeignKey(
                name: "userrol_ibfk_2",
                table: "userrol");

            migrationBuilder.DropTable(
                name: "CategoriaProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "userrol");

            migrationBuilder.DropIndex(
                name: "usuario_id",
                table: "userrol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarioscompras",
                table: "Usuarioscompras");

            migrationBuilder.DropIndex(
                name: "IX_Usuarioscompras_UsuarioId",
                table: "Usuarioscompras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transacciones",
                table: "Transacciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventarios",
                table: "Inventarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detallestransaccions",
                table: "Detallestransaccions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detallespedidos",
                table: "Detallespedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Detallescarritos",
                table: "Detallescarritos");

            migrationBuilder.DropColumn(
                name: "usuario_id",
                table: "userrol");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "userrol",
                newName: "userRol");

            migrationBuilder.RenameTable(
                name: "Usuarioscompras",
                newName: "usuarioscompras");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Transacciones",
                newName: "transacciones");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "productos");

            migrationBuilder.RenameTable(
                name: "Pedidos",
                newName: "pedidos");

            migrationBuilder.RenameTable(
                name: "Inventarios",
                newName: "inventarios");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "categorias");

            migrationBuilder.RenameTable(
                name: "Carritos",
                newName: "carritos");

            migrationBuilder.RenameTable(
                name: "Detallestransaccions",
                newName: "detallestransaccion");

            migrationBuilder.RenameTable(
                name: "Detallespedidos",
                newName: "detallespedido");

            migrationBuilder.RenameTable(
                name: "Detallescarritos",
                newName: "detallescarrito");

            migrationBuilder.RenameColumn(
                name: "rol_id",
                table: "userRol",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "userrol_id",
                table: "userRol",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "rol_id",
                table: "userRol",
                newName: "IX_userRol_RolId");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "usuarioscompras",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "TotalCompras",
                table: "usuarioscompras",
                newName: "total_compras");

            migrationBuilder.RenameColumn(
                name: "Contrasena",
                table: "usuarios",
                newName: "contrasena");

            migrationBuilder.RenameColumn(
                name: "NombreUsuario",
                table: "usuarios",
                newName: "nombre_usuario");

            migrationBuilder.RenameColumn(
                name: "CorreoElectronico",
                table: "usuarios",
                newName: "correo_electronico");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuarios",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "transacciones",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "transacciones",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "FechaTransaccion",
                table: "transacciones",
                newName: "fecha_transaccion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "transacciones",
                newName: "transaccion_id");

            migrationBuilder.RenameIndex(
                name: "IX_Transacciones_UsuarioId",
                table: "transacciones",
                newName: "usuario_id2");

            migrationBuilder.RenameColumn(
                name: "NombreRol",
                table: "roles",
                newName: "nombre_rol");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "roles",
                newName: "rol_id");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "productos",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "Existencias",
                table: "productos",
                newName: "existencias");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "productos",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "UrlProducto",
                table: "productos",
                newName: "url_producto");

            migrationBuilder.RenameColumn(
                name: "StockMinimo",
                table: "productos",
                newName: "stock_minimo");

            migrationBuilder.RenameColumn(
                name: "StockMaximo",
                table: "productos",
                newName: "stock_maximo");

            migrationBuilder.RenameColumn(
                name: "NombreProducto",
                table: "productos",
                newName: "nombre_producto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "productos",
                newName: "producto_id");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "pedidos",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "FechaPedido",
                table: "pedidos",
                newName: "fecha_pedido");

            migrationBuilder.RenameColumn(
                name: "EstadoPedido",
                table: "pedidos",
                newName: "estado_pedido");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "pedidos",
                newName: "pedido_id");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_UsuarioId",
                table: "pedidos",
                newName: "usuario_id1");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "inventarios",
                newName: "producto_id");

            migrationBuilder.RenameColumn(
                name: "FechaMovimiento",
                table: "inventarios",
                newName: "fecha_movimiento");

            migrationBuilder.RenameColumn(
                name: "CantidadNueva",
                table: "inventarios",
                newName: "cantidad_nueva");

            migrationBuilder.RenameColumn(
                name: "CantidadAnterior",
                table: "inventarios",
                newName: "cantidad_anterior");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "inventarios",
                newName: "inventario_id");

            migrationBuilder.RenameIndex(
                name: "IX_Inventarios_ProductoId",
                table: "inventarios",
                newName: "producto_id3");

            migrationBuilder.RenameColumn(
                name: "NombreCategoria",
                table: "categorias",
                newName: "nombre_categoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categorias",
                newName: "categoria_id");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "carritos",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "carritos",
                newName: "fecha_creacion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "carritos",
                newName: "carrito_id");

            migrationBuilder.RenameIndex(
                name: "IX_Carritos_UsuarioId",
                table: "carritos",
                newName: "usuario_id");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "detallestransaccion",
                newName: "cantidad");

            migrationBuilder.RenameColumn(
                name: "TransaccionId",
                table: "detallestransaccion",
                newName: "transaccion_id");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "detallestransaccion",
                newName: "producto_id");

            migrationBuilder.RenameColumn(
                name: "PrecioUnitario",
                table: "detallestransaccion",
                newName: "precio_unitario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "detallestransaccion",
                newName: "detalle_transaccion_id");

            migrationBuilder.RenameIndex(
                name: "IX_Detallestransaccions_TransaccionId",
                table: "detallestransaccion",
                newName: "transaccion_id");

            migrationBuilder.RenameIndex(
                name: "IX_Detallestransaccions_ProductoId",
                table: "detallestransaccion",
                newName: "producto_id2");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "detallespedido",
                newName: "cantidad");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "detallespedido",
                newName: "producto_id");

            migrationBuilder.RenameColumn(
                name: "PrecioUnitario",
                table: "detallespedido",
                newName: "precio_unitario");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "detallespedido",
                newName: "pedido_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "detallespedido",
                newName: "detalle_id");

            migrationBuilder.RenameIndex(
                name: "IX_Detallespedidos_ProductoId",
                table: "detallespedido",
                newName: "producto_id1");

            migrationBuilder.RenameIndex(
                name: "IX_Detallespedidos_PedidoId",
                table: "detallespedido",
                newName: "pedido_id");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "detallescarrito",
                newName: "cantidad");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "detallescarrito",
                newName: "producto_id");

            migrationBuilder.RenameColumn(
                name: "CarritoId",
                table: "detallescarrito",
                newName: "carrito_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "detallescarrito",
                newName: "detalle_carrito_id");

            migrationBuilder.RenameIndex(
                name: "IX_Detallescarritos_ProductoId",
                table: "detallescarrito",
                newName: "producto_id");

            migrationBuilder.RenameIndex(
                name: "IX_Detallescarritos_CarritoId",
                table: "detallescarrito",
                newName: "carrito_id");

            migrationBuilder.AlterDatabase(
                oldCollation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "userRol")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "usuarioscompras")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "usuarios")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "transacciones")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "roles")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "productos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "pedidos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "inventarios")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "categorias")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "carritos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "detallestransaccion")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "detallespedido")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterTable(
                name: "detallescarrito")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "RolId",
                table: "userRol",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "usuarioscompras",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "total_compras",
                table: "usuarioscompras",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "contrasena",
                table: "usuarios",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "nombre_usuario",
                table: "usuarios",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "correo_electronico",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "usuario_id",
                table: "usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "total",
                table: "transacciones",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_transaccion",
                table: "transacciones",
                type: "timestamp",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "transaccion_id",
                table: "transacciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "nombre_rol",
                table: "roles",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "rol_id",
                table: "roles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "precio",
                table: "productos",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "productos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<string>(
                name: "url_producto",
                table: "productos",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "stock_minimo",
                table: "productos",
                type: "int",
                nullable: true,
                defaultValueSql: "'0'",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "stock_maximo",
                table: "productos",
                type: "int",
                nullable: true,
                defaultValueSql: "'100'",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre_producto",
                table: "productos",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "producto_id",
                table: "productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "estado_pedido",
                table: "pedidos",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "pedido_id",
                table: "pedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_movimiento",
                table: "inventarios",
                type: "timestamp",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "inventario_id",
                table: "inventarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "nombre_categoria",
                table: "categorias",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<int>(
                name: "categoria_id",
                table: "categorias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_creacion",
                table: "carritos",
                type: "timestamp",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "carrito_id",
                table: "carritos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "precio_unitario",
                table: "detallestransaccion",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<int>(
                name: "detalle_transaccion_id",
                table: "detallestransaccion",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "precio_unitario",
                table: "detallespedido",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<int>(
                name: "detalle_id",
                table: "detallespedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "detalle_carrito_id",
                table: "detallescarrito",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_userRol",
                table: "userRol",
                columns: new[] { "UserId", "RolId" });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "usuarioscompras",
                column: "usuario_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "usuarios",
                column: "usuario_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "transacciones",
                column: "transaccion_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "roles",
                column: "rol_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "productos",
                column: "producto_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "pedidos",
                column: "pedido_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "inventarios",
                column: "inventario_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "categorias",
                column: "categoria_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "carritos",
                column: "carrito_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "detallestransaccion",
                column: "detalle_transaccion_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "detallespedido",
                column: "detalle_id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "detallescarrito",
                column: "detalle_carrito_id");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_usuarios_UserId",
                        column: x => x.UserId,
                        principalTable: "usuarios",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "productoscategorias",
                columns: table => new
                {
                    producto_id = table.Column<int>(type: "int", nullable: false),
                    categoria_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.producto_id, x.categoria_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "productoscategorias_ibfk_1",
                        column: x => x.producto_id,
                        principalTable: "productos",
                        principalColumn: "producto_id");
                    table.ForeignKey(
                        name: "productoscategorias_ibfk_2",
                        column: x => x.categoria_id,
                        principalTable: "categorias",
                        principalColumn: "categoria_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "categoria_id",
                table: "productoscategorias",
                column: "categoria_id");

            migrationBuilder.AddForeignKey(
                name: "carritos_ibfk_1",
                table: "carritos",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "usuario_id");

            migrationBuilder.AddForeignKey(
                name: "detallescarrito_ibfk_1",
                table: "detallescarrito",
                column: "carrito_id",
                principalTable: "carritos",
                principalColumn: "carrito_id");

            migrationBuilder.AddForeignKey(
                name: "detallescarrito_ibfk_2",
                table: "detallescarrito",
                column: "producto_id",
                principalTable: "productos",
                principalColumn: "producto_id");

            migrationBuilder.AddForeignKey(
                name: "detallespedido_ibfk_1",
                table: "detallespedido",
                column: "pedido_id",
                principalTable: "pedidos",
                principalColumn: "pedido_id");

            migrationBuilder.AddForeignKey(
                name: "detallespedido_ibfk_2",
                table: "detallespedido",
                column: "producto_id",
                principalTable: "productos",
                principalColumn: "producto_id");

            migrationBuilder.AddForeignKey(
                name: "detallestransaccion_ibfk_1",
                table: "detallestransaccion",
                column: "transaccion_id",
                principalTable: "transacciones",
                principalColumn: "transaccion_id");

            migrationBuilder.AddForeignKey(
                name: "detallestransaccion_ibfk_2",
                table: "detallestransaccion",
                column: "producto_id",
                principalTable: "productos",
                principalColumn: "producto_id");

            migrationBuilder.AddForeignKey(
                name: "inventarios_ibfk_1",
                table: "inventarios",
                column: "producto_id",
                principalTable: "productos",
                principalColumn: "producto_id");

            migrationBuilder.AddForeignKey(
                name: "pedidos_ibfk_1",
                table: "pedidos",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "usuario_id");

            migrationBuilder.AddForeignKey(
                name: "transacciones_ibfk_1",
                table: "transacciones",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "usuario_id");

            migrationBuilder.AddForeignKey(
                name: "FK_userRol_roles_RolId",
                table: "userRol",
                column: "RolId",
                principalTable: "roles",
                principalColumn: "rol_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userRol_usuarios_UserId",
                table: "userRol",
                column: "UserId",
                principalTable: "usuarios",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "usuarioscompras_ibfk_1",
                table: "usuarioscompras",
                column: "usuario_id",
                principalTable: "usuarios",
                principalColumn: "usuario_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "carritos_ibfk_1",
                table: "carritos");

            migrationBuilder.DropForeignKey(
                name: "detallescarrito_ibfk_1",
                table: "detallescarrito");

            migrationBuilder.DropForeignKey(
                name: "detallescarrito_ibfk_2",
                table: "detallescarrito");

            migrationBuilder.DropForeignKey(
                name: "detallespedido_ibfk_1",
                table: "detallespedido");

            migrationBuilder.DropForeignKey(
                name: "detallespedido_ibfk_2",
                table: "detallespedido");

            migrationBuilder.DropForeignKey(
                name: "detallestransaccion_ibfk_1",
                table: "detallestransaccion");

            migrationBuilder.DropForeignKey(
                name: "detallestransaccion_ibfk_2",
                table: "detallestransaccion");

            migrationBuilder.DropForeignKey(
                name: "inventarios_ibfk_1",
                table: "inventarios");

            migrationBuilder.DropForeignKey(
                name: "pedidos_ibfk_1",
                table: "pedidos");

            migrationBuilder.DropForeignKey(
                name: "transacciones_ibfk_1",
                table: "transacciones");

            migrationBuilder.DropForeignKey(
                name: "FK_userRol_roles_RolId",
                table: "userRol");

            migrationBuilder.DropForeignKey(
                name: "FK_userRol_usuarios_UserId",
                table: "userRol");

            migrationBuilder.DropForeignKey(
                name: "usuarioscompras_ibfk_1",
                table: "usuarioscompras");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "productoscategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "usuarioscompras");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userRol",
                table: "userRol");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "transacciones");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "productos");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "inventarios");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "categorias");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "carritos");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "detallestransaccion");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "detallespedido");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "detallescarrito");

            migrationBuilder.RenameTable(
                name: "usuarioscompras",
                newName: "Usuarioscompras");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "userRol",
                newName: "userrol");

            migrationBuilder.RenameTable(
                name: "transacciones",
                newName: "Transacciones");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "productos",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "pedidos",
                newName: "Pedidos");

            migrationBuilder.RenameTable(
                name: "inventarios",
                newName: "Inventarios");

            migrationBuilder.RenameTable(
                name: "categorias",
                newName: "Categorias");

            migrationBuilder.RenameTable(
                name: "carritos",
                newName: "Carritos");

            migrationBuilder.RenameTable(
                name: "detallestransaccion",
                newName: "Detallestransaccions");

            migrationBuilder.RenameTable(
                name: "detallespedido",
                newName: "Detallespedidos");

            migrationBuilder.RenameTable(
                name: "detallescarrito",
                newName: "Detallescarritos");

            migrationBuilder.RenameColumn(
                name: "total_compras",
                table: "Usuarioscompras",
                newName: "TotalCompras");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Usuarioscompras",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "contrasena",
                table: "Usuarios",
                newName: "Contrasena");

            migrationBuilder.RenameColumn(
                name: "nombre_usuario",
                table: "Usuarios",
                newName: "NombreUsuario");

            migrationBuilder.RenameColumn(
                name: "correo_electronico",
                table: "Usuarios",
                newName: "CorreoElectronico");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Usuarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "userrol",
                newName: "rol_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "userrol",
                newName: "userrol_id");

            migrationBuilder.RenameIndex(
                name: "IX_userRol_RolId",
                table: "userrol",
                newName: "rol_id");

            migrationBuilder.RenameColumn(
                name: "total",
                table: "Transacciones",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Transacciones",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "fecha_transaccion",
                table: "Transacciones",
                newName: "FechaTransaccion");

            migrationBuilder.RenameColumn(
                name: "transaccion_id",
                table: "Transacciones",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "usuario_id2",
                table: "Transacciones",
                newName: "IX_Transacciones_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "nombre_rol",
                table: "Roles",
                newName: "NombreRol");

            migrationBuilder.RenameColumn(
                name: "rol_id",
                table: "Roles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Productos",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "existencias",
                table: "Productos",
                newName: "Existencias");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Productos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "url_producto",
                table: "Productos",
                newName: "UrlProducto");

            migrationBuilder.RenameColumn(
                name: "stock_minimo",
                table: "Productos",
                newName: "StockMinimo");

            migrationBuilder.RenameColumn(
                name: "stock_maximo",
                table: "Productos",
                newName: "StockMaximo");

            migrationBuilder.RenameColumn(
                name: "nombre_producto",
                table: "Productos",
                newName: "NombreProducto");

            migrationBuilder.RenameColumn(
                name: "producto_id",
                table: "Productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Pedidos",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "fecha_pedido",
                table: "Pedidos",
                newName: "FechaPedido");

            migrationBuilder.RenameColumn(
                name: "estado_pedido",
                table: "Pedidos",
                newName: "EstadoPedido");

            migrationBuilder.RenameColumn(
                name: "pedido_id",
                table: "Pedidos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "usuario_id1",
                table: "Pedidos",
                newName: "IX_Pedidos_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "producto_id",
                table: "Inventarios",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "fecha_movimiento",
                table: "Inventarios",
                newName: "FechaMovimiento");

            migrationBuilder.RenameColumn(
                name: "cantidad_nueva",
                table: "Inventarios",
                newName: "CantidadNueva");

            migrationBuilder.RenameColumn(
                name: "cantidad_anterior",
                table: "Inventarios",
                newName: "CantidadAnterior");

            migrationBuilder.RenameColumn(
                name: "inventario_id",
                table: "Inventarios",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "producto_id3",
                table: "Inventarios",
                newName: "IX_Inventarios_ProductoId");

            migrationBuilder.RenameColumn(
                name: "nombre_categoria",
                table: "Categorias",
                newName: "NombreCategoria");

            migrationBuilder.RenameColumn(
                name: "categoria_id",
                table: "Categorias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuario_id",
                table: "Carritos",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "Carritos",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "carrito_id",
                table: "Carritos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "usuario_id",
                table: "Carritos",
                newName: "IX_Carritos_UsuarioId");

            migrationBuilder.RenameColumn(
                name: "cantidad",
                table: "Detallestransaccions",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "transaccion_id",
                table: "Detallestransaccions",
                newName: "TransaccionId");

            migrationBuilder.RenameColumn(
                name: "producto_id",
                table: "Detallestransaccions",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "precio_unitario",
                table: "Detallestransaccions",
                newName: "PrecioUnitario");

            migrationBuilder.RenameColumn(
                name: "detalle_transaccion_id",
                table: "Detallestransaccions",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "transaccion_id",
                table: "Detallestransaccions",
                newName: "IX_Detallestransaccions_TransaccionId");

            migrationBuilder.RenameIndex(
                name: "producto_id2",
                table: "Detallestransaccions",
                newName: "IX_Detallestransaccions_ProductoId");

            migrationBuilder.RenameColumn(
                name: "cantidad",
                table: "Detallespedidos",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "producto_id",
                table: "Detallespedidos",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "precio_unitario",
                table: "Detallespedidos",
                newName: "PrecioUnitario");

            migrationBuilder.RenameColumn(
                name: "pedido_id",
                table: "Detallespedidos",
                newName: "PedidoId");

            migrationBuilder.RenameColumn(
                name: "detalle_id",
                table: "Detallespedidos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "producto_id1",
                table: "Detallespedidos",
                newName: "IX_Detallespedidos_ProductoId");

            migrationBuilder.RenameIndex(
                name: "pedido_id",
                table: "Detallespedidos",
                newName: "IX_Detallespedidos_PedidoId");

            migrationBuilder.RenameColumn(
                name: "cantidad",
                table: "Detallescarritos",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "producto_id",
                table: "Detallescarritos",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "carrito_id",
                table: "Detallescarritos",
                newName: "CarritoId");

            migrationBuilder.RenameColumn(
                name: "detalle_carrito_id",
                table: "Detallescarritos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "producto_id",
                table: "Detallescarritos",
                newName: "IX_Detallescarritos_ProductoId");

            migrationBuilder.RenameIndex(
                name: "carrito_id",
                table: "Detallescarritos",
                newName: "IX_Detallescarritos_CarritoId");

            migrationBuilder.AlterDatabase(
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Usuarioscompras")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Usuarios")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "userrol")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Transacciones")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Roles")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Productos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Pedidos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Inventarios")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Categorias")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Carritos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Detallestransaccions")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Detallespedidos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterTable(
                name: "Detallescarritos")
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Usuarioscompras",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalCompras",
                table: "Usuarioscompras",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Contrasena",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NombreUsuario",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CorreoElectronico",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Usuarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "rol_id",
                table: "userrol",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "usuario_id",
                table: "userrol",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Transacciones",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaTransaccion",
                table: "Transacciones",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Transacciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "NombreRol",
                table: "Roles",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Roles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UrlProducto",
                table: "Productos",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "StockMinimo",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "'0'");

            migrationBuilder.AlterColumn<int>(
                name: "StockMaximo",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "'100'");

            migrationBuilder.AlterColumn<string>(
                name: "NombreProducto",
                table: "Productos",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "EstadoPedido",
                table: "Pedidos",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMovimiento",
                table: "Inventarios",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Inventarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "NombreCategoria",
                table: "Categorias",
                type: "longtext",
                nullable: true,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categorias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Carritos",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true,
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Carritos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Detallestransaccions",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Detallestransaccions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Detallespedidos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Detallespedidos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Detallescarritos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarioscompras",
                table: "Usuarioscompras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "userrol",
                column: "userrol_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transacciones",
                table: "Transacciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedidos",
                table: "Pedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventarios",
                table: "Inventarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carritos",
                table: "Carritos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detallestransaccions",
                table: "Detallestransaccions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detallespedidos",
                table: "Detallespedidos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Detallescarritos",
                table: "Detallescarritos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoriaProducto",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaProducto", x => new { x.CategoriaId, x.ProductosId });
                    table.ForeignKey(
                        name: "FK_CategoriaProducto_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaProducto_Productos_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarioscompras_UsuarioId",
                table: "Usuarioscompras",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "usuario_id",
                table: "userrol",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaProducto_ProductosId",
                table: "CategoriaProducto",
                column: "ProductosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carritos_Usuarios_UsuarioId",
                table: "Carritos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detallescarritos_Carritos_CarritoId",
                table: "Detallescarritos",
                column: "CarritoId",
                principalTable: "Carritos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detallescarritos_Productos_ProductoId",
                table: "Detallescarritos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detallespedidos_Pedidos_PedidoId",
                table: "Detallespedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detallespedidos_Productos_ProductoId",
                table: "Detallespedidos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detallestransaccions_Productos_ProductoId",
                table: "Detallestransaccions",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detallestransaccions_Transacciones_TransaccionId",
                table: "Detallestransaccions",
                column: "TransaccionId",
                principalTable: "Transacciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventarios_Productos_ProductoId",
                table: "Inventarios",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Usuarios_UsuarioId",
                table: "Pedidos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacciones_Usuarios_UsuarioId",
                table: "Transacciones",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarioscompras_Usuarios_UsuarioId",
                table: "Usuarioscompras",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "userrol_ibfk_1",
                table: "userrol",
                column: "usuario_id",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "userrol_ibfk_2",
                table: "userrol",
                column: "rol_id",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
