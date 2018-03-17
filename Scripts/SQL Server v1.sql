DROP TABLE parqueo CASCADE CONSTRAINTS;
DROP TABLE usuario CASCADE CONSTRAINTS;
DROP TABLE espacio CASCADE CONSTRAINTS;
DROP TABLE factura CASCADE CONSTRAINTS;


CREATE TABLE parqueo (
    id_localidad        INTEGER(10) NOT NULL,
    localidad           VARCHAR(10) NOT NULL,
    cantidad_espacios   INTEGER(10) NOT NULL,
    nombre_parqueo      VARCHAR(45) NOT NULL
);

ALTER TABLE parqueo ADD CONSTRAINT parqueo_pk PRIMARY KEY ( id_localidad );


CREATE TABLE usuario (
    id_usuario       INTEGER(4) NOT NULL,
    nombre           VARCHAR(35) NOT NULL,
    apellido         VARCHAR(35) NOT NULL,
    correo           VARCHAR(100) NOT NULL,
    usuario          VARCHAR(35) NOT NULL,
    contrasena       VARCHAR(16) NOT NULL,
    placa_vehiculo   VARCHAR(10) NOT NULL
);

ALTER TABLE usuario ADD CONSTRAINT usuario_pk PRIMARY KEY ( id_usuario );



CREATE TABLE espacio (
    id_espacio             INTEGER(10) NOT NULL,
    estado                 CHAR(1) NOT NULL,
    hora_entrada           DATETIME2 NOT NULL,
    hora_salida            DATETIME2 NOT NULL,
    tiempo_reserva         DATETIME2 NOT NULL,
    usuario_id_usuario     INTEGER(4) NOT NULL,
    parqueo_id_localidad   INTEGER(10) NOT NULL
);

ALTER TABLE espacio ADD CONSTRAINT espacio_pk PRIMARY KEY ( id_espacio );

ALTER TABLE espacio
    ADD CONSTRAINT espacio_parqueo_fk FOREIGN KEY ( parqueo_id_localidad )
        REFERENCES parqueo ( id_localidad );

ALTER TABLE espacio
    ADD CONSTRAINT espacio_usuario_fk FOREIGN KEY ( usuario_id_usuario )
        REFERENCES usuario ( id_usuario );

CREATE UNIQUE INDEX espacio__idx ON
    espacio ( usuario_id_usuario ASC );



CREATE TABLE factura (
    id_factura           INTEGER(10) NOT NULL,
    espacio_id_espacio   INTEGER(10) NOT NULL,
    usuario_id_usuario   INTEGER(4) NOT NULL,
    monto                DECIMAL(20) NOT NULL
);

ALTER TABLE factura ADD CONSTRAINT factura_pk PRIMARY KEY ( id_factura );

ALTER TABLE factura
    ADD CONSTRAINT factura_usuario_fk FOREIGN KEY ( usuario_id_usuario )
        REFERENCES usuario ( id_usuario );

ALTER TABLE factura
    ADD CONSTRAINT factura_espacio_fk FOREIGN KEY ( espacio_id_espacio )
        REFERENCES espacio ( id_espacio );