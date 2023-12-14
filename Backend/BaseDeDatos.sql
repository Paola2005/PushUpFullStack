-- Tabla de Roles
CREATE TABLE Roles (
    rol_id INT PRIMARY KEY,
    nombre_rol VARCHAR(50) NOT NULL
);

-- Tabla de Usuarios
CREATE TABLE Usuarios (
    usuario_id INT PRIMARY KEY,
    nombre_usuario VARCHAR(50) NOT NULL,
    correo_electronico VARCHAR(100) NOT NULL,
    contrasena VARCHAR(255) NOT NULL,
    rol_id INT,
    FOREIGN KEY (rol_id) REFERENCES Roles(rol_id)
);

-- Tabla de Productos
CREATE TABLE Productos (
    producto_id INT PRIMARY KEY,
    nombre_producto VARCHAR(100) NOT NULL,
    descripcion TEXT,
    precio DECIMAL(10, 2) NOT NULL,
    existencias INT NOT NULL,
    stock_minimo INT DEFAULT 0,
    stock_maximo INT DEFAULT 100,
    url_producto VARCHAR(255)
);

-- Tabla de Categorías
CREATE TABLE Categorias (
    categoria_id INT PRIMARY KEY,
    nombre_categoria VARCHAR(50) NOT NULL
);

-- Relación entre Productos y Categorías
CREATE TABLE ProductosCategorias (
    producto_id INT,
    categoria_id INT,
    PRIMARY KEY (producto_id, categoria_id),
    FOREIGN KEY (producto_id) REFERENCES Productos(producto_id),
    FOREIGN KEY (categoria_id) REFERENCES Categorias(categoria_id)
);

-- Tabla de Pedidos
CREATE TABLE Pedidos (
    pedido_id INT PRIMARY KEY,
    usuario_id INT,
    fecha_pedido DATE NOT NULL,
    estado_pedido VARCHAR(20) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(usuario_id)
);

-- Tabla de Detalles de Pedido
CREATE TABLE DetallesPedido (
    detalle_id INT PRIMARY KEY,
    pedido_id INT,
    producto_id INT,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (pedido_id) REFERENCES Pedidos(pedido_id),
    FOREIGN KEY (producto_id) REFERENCES Productos(producto_id)
);

-- Tabla de Carritos
CREATE TABLE Carritos (
    carrito_id INT PRIMARY KEY,
    usuario_id INT,
    fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(usuario_id)
);

-- Tabla de Detalles del Carrito
CREATE TABLE DetallesCarrito (
    detalle_carrito_id INT PRIMARY KEY,
    carrito_id INT,
    producto_id INT,
    cantidad INT NOT NULL,
    FOREIGN KEY (carrito_id) REFERENCES Carritos(carrito_id),
    FOREIGN KEY (producto_id) REFERENCES Productos(producto_id)
);

-- Tabla de Transacciones
CREATE TABLE Transacciones (
    transaccion_id INT PRIMARY KEY,
    usuario_id INT,
    fecha_transaccion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    total DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(usuario_id)
);

-- Tabla de Detalles de Transacción
CREATE TABLE DetallesTransaccion (
    detalle_transaccion_id INT PRIMARY KEY,
    transaccion_id INT,
    producto_id INT,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (transaccion_id) REFERENCES Transacciones(transaccion_id),
    FOREIGN KEY (producto_id) REFERENCES Productos(producto_id)
);

-- Tabla de Inventarios
CREATE TABLE Inventarios (
    inventario_id INT PRIMARY KEY,
    producto_id INT,
    cantidad_anterior INT NOT NULL,
    cantidad_nueva INT NOT NULL,
    fecha_movimiento TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (producto_id) REFERENCES Productos(producto_id)
);

-- Tabla de Ventas Diarias
CREATE TABLE VentasDiarias (
    fecha DATE PRIMARY KEY,
    total_ventas DECIMAL(10, 2) NOT NULL
);

-- Tabla de Usuarios y Sus Compras
CREATE TABLE UsuariosCompras (
    usuario_id INT PRIMARY KEY,
    total_compras DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES Usuarios(usuario_id)
);




-- Datos de ejemplo para la tabla Roles
INSERT INTO Roles (rol_id, nombre_rol) VALUES
(1, 'Admin'),
(2, 'Cliente');

-- Datos de ejemplo para la tabla Usuarios
INSERT INTO Usuarios (usuario_id, nombre_usuario, correo_electronico, contrasena, rol_id) VALUES
(1, 'admin_nike', 'admin@nike.com', 'contraseña_admin', 1),
(2, 'usuario1', 'usuario1@gmail.com', 'contraseña_usuario1', 2),
(3, 'usuario2', 'usuario2@gmail.com', 'contraseña_usuario2', 2),
(4, 'invitado1', 'invitado1@gmail.com', 'contraseña_invitado1', 2),
(5, 'invitado2', 'invitado2@gmail.com', 'contraseña_invitado2', 2),
(6, 'cliente3', 'cliente3@gmail.com', 'contraseña_cliente3', 2),
(7, 'cliente4', 'cliente4@gmail.com', 'contraseña_cliente4', 2),
(8, 'cliente5', 'cliente5@gmail.com', 'contraseña_cliente5', 2),
(9, 'cliente6', 'cliente6@gmail.com', 'contraseña_cliente6', 2),
(10, 'cliente7', 'cliente7@gmail.com', 'contraseña_cliente7', 2);

-- Datos de ejemplo para la tabla Categorias
INSERT INTO Categorias (categoria_id, nombre_categoria) VALUES
(1, 'Zapatillas'),
(2, 'Ropa Deportiva'),
(3, 'Accesorios'),
(4, 'Balones'),
(5, 'Equipamiento'),
(6, 'Gorras'),
(7, 'Calcetines'),
(8, 'Relojes'),
(9, 'Mochilas'),
(10, 'Otros');

-- Datos de ejemplo para la tabla Productos
INSERT INTO Productos (producto_id, nombre_producto, descripcion, precio, existencias, stock_minimo, stock_maximo, url_producto) VALUES
(1, 'Air Max 270', 'Zapatillas para correr', 129.99, 50, 10, 100, 'https://www.ejemplo.com/air-max-270'),
(2, 'Dry-FIT Camiseta', 'Camiseta deportiva de secado rápido', 29.99, 100, 20, 150, 'https://www.ejemplo.com/dry-fit-camiseta'),
(3, 'Flex Experience RN 10', 'Zapatillas de running', 79.99, 30, 5, 80, 'https://www.ejemplo.com/flex-experience-rn-10'),
(4, 'Therma-FIT Sudadera con Capucha', 'Sudadera con capucha térmica', 49.99, 80, 15, 120, 'https://www.ejemplo.com/therma-fit-sudadera'),
(5, 'React Infinity Run Flyknit', 'Zapatillas para correr con tecnología React', 149.99, 40, 10, 90, 'https://www.ejemplo.com/react-infinity-run-flyknit'),
(6, 'Elite Basketball Shorts', 'Shorts de baloncesto de élite', 39.99, 60, 10, 80, 'https://www.ejemplo.com/elite-basketball-shorts'),
(7, 'Zoom Pegasus Turbo', 'Zapatillas de running con tecnología Zoom', 179.99, 20, 5, 50, 'https://www.ejemplo.com/zoom-pegasus-turbo'),
(8, 'Pro Therma Hoodie', 'Sudadera con capucha térmica profesional', 69.99, 70, 15, 100, 'https://www.ejemplo.com/pro-therma-hoodie'),
(9, 'Epic Luxe Leggings', 'Mallas deportivas de alta gama', 59.99, 50, 10, 80, 'https://www.ejemplo.com/epic-luxe-leggings'),
(10, 'Revolution 5', 'Zapatillas para correr Revolution 5', 89.99, 25, 5, 60, 'https://www.ejemplo.com/revolution-5');

-- Datos de ejemplo para la tabla ProductosCategorias
INSERT INTO ProductosCategorias (producto_id, categoria_id) VALUES
(1, 1),
(2, 2),
(3, 1),
(4, 2),
(5, 1),
(6, 2),
(7, 1),
(8, 2),
(9, 2),
(10, 1);

-- Datos de ejemplo para la tabla Carritos
INSERT INTO Carritos (carrito_id, usuario_id) VALUES
(1, 2),
(2, 3),
(3, 4),
(4, 5),
(5, 6),
(6, 7),
(7, 8),
(8, 9),
(9, 10),
(10, 2);

-- Datos de ejemplo para la tabla DetallesCarrito
INSERT INTO DetallesCarrito (detalle_carrito_id, carrito_id, producto_id, cantidad) VALUES
(1, 1, 4, 3),
(2, 2, 5, 1),
(3, 3, 7, 2),
(4, 4, 9, 1),
(5, 5, 2, 2),
(6, 6, 6, 3),
(7, 7, 8, 1),
(8, 8, 10, 2),
(9, 9, 1, 1),
(10, 10, 3, 2);

-- Datos de ejemplo para la tabla Pedidos
INSERT INTO Pedidos (pedido_id, usuario_id, fecha_pedido, estado_pedido) VALUES
(1, 2, '2023-12-01', 'En Proceso'),
(2, 3, '2023-12-02', 'Entregado'),
(3, 4, '2023-12-03', 'En Proceso'),
(4, 5, '2023-12-04', 'Entregado'),
(5, 6, '2023-12-05', 'En Proceso'),
(6, 7, '2023-12-06', 'Entregado'),
(7, 8, '2023-12-07', 'En Proceso'),
(8, 9, '2023-12-08', 'Entregado'),
(9, 10, '2023-12-09', 'En Proceso'),
(10, 2, '2023-12-10', 'Entregado');

-- Datos de ejemplo para la tabla DetallesPedido
INSERT INTO DetallesPedido (detalle_id, pedido_id, producto_id, cantidad, precio_unitario) VALUES
(1, 1, 1, 2, 129.99),
(2, 2, 3, 1, 79.99),
(3, 3, 5, 3, 149.99),
(4, 4, 8, 2, 69.99),
(5, 5, 10, 1, 89.99),
(6, 6, 2, 2, 29.99),
(7, 7, 4, 1, 49.99),
(8, 8, 6, 3, 39.99),
(9, 9, 9, 1, 59.99),
(10, 10, 7, 2, 179.99);

-- Datos de ejemplo para la tabla Transacciones
INSERT INTO Transacciones (transaccion_id, usuario_id, total) VALUES
(1, 2, 439.95),
(2, 3, 179.98),
(3, 4, 449.97),
(4, 5, 199.97),
(5, 6, 269.97),
(6, 7, 159.96),
(7, 8, 159.96),
(8, 9, 239.94),
(9, 10, 99.98),
(10, 2, 359.97);

-- Datos de ejemplo para la tabla DetallesTransaccion
INSERT INTO DetallesTransaccion (detalle_transaccion_id, transaccion_id, producto_id, cantidad, precio_unitario) VALUES
(1, 1, 1, 2, 129.99),
(2, 2, 3, 1, 79.99),
(3, 3, 5, 2, 149.99),
(4, 4, 8, 1, 69.99),
(5, 5, 10, 1, 89.99),
(6, 6, 2, 1, 29.99),
(7, 7, 4, 3, 49.99),
(8, 8, 6, 2, 39.99),
(9, 9, 9, 1, 59.99),
(10, 10, 7, 2, 179.99);

-- Datos de ejemplo para la tabla Inventarios
INSERT INTO Inventarios (inventario_id, producto_id, cantidad_anterior, cantidad_nueva) VALUES
(1, 1, 50, 48),
(2, 3, 30, 29),
(3, 4, 80, 77),
(4, 5, 40, 38),
(5, 6, 60, 57),
(6, 7, 20, 19),
(7, 8, 70, 68),
(8, 9, 50, 49),
(9, 10, 25, 23),
(10, 2, 100, 97);