DROP TABLE parqueo CASCADE CONSTRAINTS;
DROP TABLE usuario CASCADE CONSTRAINTS;
DROP TABLE espacio CASCADE CONSTRAINTS;
DROP TABLE factura CASCADE CONSTRAINTS;


CREATE TABLE parqueo (
    id_localidad        INTEGER(10) NOT NULL,
    localidad           VARCHAR(10) NOT NULL,
    cantidad_espacios   INTEGER(10) NOT NULL,
    nombre_parqueo      VARCHAR(45) NOT NULL,
	CONSTRAINT parqueo_pk PRIMARY KEY ( id_localidad ),
	CONSTRAINT cK_cantidad_espacio CHECK(cantidad_espacios > 0),
	CONSTRAINT cK_idlocalidad CHECK(id_localidad > 0)
);
 

CREATE TABLE usuario (
    id_usuario       INTEGER(4) NOT NULL,
    nombre           VARCHAR(35) NOT NULL,
    apellido         VARCHAR(35) NOT NULL,
    correo           VARCHAR(100) NOT NULL,
    usuario          VARCHAR(35) NOT NULL,
    contrasena       VARCHAR(16) NOT NULL,
    placa_vehiculo   VARCHAR(10) NOT NULL,
	CONSTRAINT usuario_pk PRIMARY KEY ( id_usuario ),
	CONSTRAINT cK_idusuario CHECK(id_usuario > 0),
	CONSTRAINT cK_correo CHECK(correo LIKE('%_@_%_.__%'))
);
 


CREATE TABLE espacio (
    id_espacio             INTEGER(10) NOT NULL,
    estado                 CHAR(1) NOT NULL,
    hora_entrada           DATETIME2 NOT NULL,
    hora_salida            DATETIME2 NOT NULL,
    tiempo_reserva         DATETIME2 NOT NULL,
    usuario_id_usuario     INTEGER(4) NOT NULL,
    parqueo_id_localidad   INTEGER(10) NOT NULL,
	CONSTRAINT espacio_pk PRIMARY KEY ( id_espacio ),
	CONSTRAINT espacio_parqueo_fk FOREIGN KEY ( parqueo_id_localidad )
        	REFERENCES parqueo ( id_localidad ),
	CONSTRAINT espacio_usuario_fk FOREIGN KEY ( usuario_id_usuario )
        	REFERENCES usuario ( id_usuario ),
	CONSTRAINT cK_idespacio CHECK(id_espacio > 0),
	CONSTRAINT cK_horario CHECK(hora_salida > hora_entrada),
);

CREATE UNIQUE INDEX espacio__idx ON
    espacio ( usuario_id_usuario ASC );



CREATE TABLE factura (
    id_factura           INTEGER(10) NOT NULL,
    espacio_id_espacio   INTEGER(10) NOT NULL,
    usuario_id_usuario   INTEGER(4) NOT NULL,
    monto                DECIMAL(20) NOT NULL,
	CONSTRAINT factura_pk PRIMARY KEY ( id_factura ),
	CONSTRAINT factura_usuario_fk FOREIGN KEY ( usuario_id_usuario )
        	REFERENCES usuario ( id_usuario ),
	CONSTRAINT factura_espacio_fk FOREIGN KEY ( espacio_id_espacio )
        	REFERENCES espacio ( id_espacio ),
	CONSTRAINT cK_idfactura CHECK(id_factura > 0),
	CONSTRAINT cK_monto CHECK(monto > 0)
);






