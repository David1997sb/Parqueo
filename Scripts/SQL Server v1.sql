DROP TABLE parqueo;
DROP TABLE usuario;
DROP TABLE espacio;
DROP TABLE factura;


CREATE TABLE parqueo (
    id_localidad        INT NOT NULL,
    localidad           VARCHAR(10) NOT NULL,
    cantidad_espacios   INT NOT NULL,
    nombre_parqueo      VARCHAR(45) NOT NULL,
	CONSTRAINT parqueo_pk PRIMARY KEY ( id_localidad ),
	CONSTRAINT cK_cantidad_espacio CHECK(cantidad_espacios > 0),
	CONSTRAINT cK_idlocalidad CHECK(id_localidad > 0)
);
 

CREATE TABLE usuario (
    usuario          VARCHAR(35) NOT NULL,
    nombre           VARCHAR(35) NOT NULL,
    apellido         VARCHAR(35) NOT NULL,
    correo           VARCHAR(100) NOT NULL,
    contrasena       VARCHAR(16) NOT NULL,
    placa_vehiculo   VARCHAR(10) NOT NULL,
	CONSTRAINT usuario_pk PRIMARY KEY ( usuario ),
	CONSTRAINT cK_correo CHECK(correo LIKE('%_@_%_.__%'))
);
 

CREATE TABLE espacio (
    id_espacio             INT NOT NULL,
    estado                 INT NOT NULL,
    hora_entrada           DATETIME2 NOT NULL,
    hora_salida            DATETIME2 NOT NULL,
    tiempo_reserva         DATETIME2 NOT NULL,
    usuario		   VARCHAR(35) NOT NULL,
    parqueo_id_localidad   INT NOT NULL,
	CONSTRAINT espacio_pk PRIMARY KEY ( id_espacio ),
	CONSTRAINT espacio_parqueo_fk FOREIGN KEY ( parqueo_id_localidad )
        	REFERENCES parqueo ( id_localidad ),
	CONSTRAINT espacio_usuario_fk FOREIGN KEY ( usuario )
        	REFERENCES usuario ( usuario ),
	CONSTRAINT cK_idespacio CHECK(id_espacio > 0),
	CONSTRAINT cK_horario CHECK(hora_salida > hora_entrada),
	CONSTRAINT cK_estado CHECK(estado IN (1,2,3))
);


CREATE TABLE factura (
    id_factura           INT NOT NULL,
    espacio_id_espacio   INT NOT NULL,
    usuario   		 VARCHAR(35) NOT NULL,
    monto                DECIMAL(20) NOT NULL,
	CONSTRAINT factura_pk PRIMARY KEY ( id_factura ),
	CONSTRAINT factura_usuario_fk FOREIGN KEY ( usuario )
        	REFERENCES usuario ( usuario ),
	CONSTRAINT factura_espacio_fk FOREIGN KEY ( espacio_id_espacio )
        	REFERENCES espacio ( id_espacio ),
	CONSTRAINT cK_idfactura CHECK(id_factura > 0),
	CONSTRAINT cK_monto CHECK(monto > 0)
);