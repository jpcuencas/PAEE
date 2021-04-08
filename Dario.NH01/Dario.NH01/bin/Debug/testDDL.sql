alter table LineaFactura  drop constraint FK840F0A963DE64B1F
alter table LineaFactura  drop constraint FK840F0A96C45CE1E4
if exists (select * from dbo.sysobjects where id = object_id(N'Factura') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Factura
if exists (select * from dbo.sysobjects where id = object_id(N'Producto') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Producto
if exists (select * from dbo.sysobjects where id = object_id(N'LineaFactura') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table LineaFactura
create table Factura (
  IdFactura INT IDENTITY NOT NULL,
   Fecha DATETIME not null,
   primary key (IdFactura)
)
create table Producto (
  IdProducto INT IDENTITY NOT NULL,
   Categoria NVARCHAR(255) null,
   Nombre NVARCHAR(255) null,
   primary key (IdProducto)
)
create table LineaFactura (
  IdLineaFactura INT IDENTITY NOT NULL,
   Cantidad INT null,
   Precio DECIMAL(19,5) null,
   IdFactura INT null,
   IdProducto INT null,
   primary key (IdLineaFactura)
)
alter table LineaFactura  add constraint FK840F0A963DE64B1F foreign key (IdFactura) references Factura 
alter table LineaFactura  add constraint FK840F0A96C45CE1E4 foreign key (IdProducto) references Producto 
