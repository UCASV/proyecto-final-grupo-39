CREATE DATABASE BancoDatos;

Use BancoDatos

CREATE TABLE REGISTRO(
	id_registro int identity (1,1) primary key not null,
	id_gestor int,
	cabina varchar (50),
	fecha_hora datetime
);

CREATE TABLE GESTOR(
	id_gestor int primary key not null,
	nombre varchar(50),
	correo_institucional varchar(50),
	direccion_vivienda varchar(50),
	usuario varchar(50),
	contraseña varchar(50)
);

CREATE TABLE TRABAJA(
	id_trabaja int primary key not null,
	id_gestor int,
	id_empleado int
);

CREATE TABLE EMPLEADO(
	id_empleado int primary key not null,
	nombre varchar(50),
	correo_institucional varchar(50),
	direccion_vivienda varchar(50),
	id_tipo_empleado int
);

CREATE TABLE TIPO_EMPLEADO(
	id_tipo_empleado int primary key not null,
	tipo_empleado varchar(50)
);

CREATE TABLE GESTION(
	id_gestion int IDENTITY(1,1) primary key not null,
	id_gestor int,
	id_empleado int,
	id_cabina int
);

CREATE TABLE CABINA(
	id_cabina int primary key not null,
	direccion varchar(50),
	telefono varchar(50),
	nombre_encargado varchar(50),
	correo_electronico varchar(50)
);

CREATE TABLE CIUDADANO(
	dui_ciudadano varchar(10) primary key not null,
	id_gestor int,
	domicilio varchar(50),
	nombre varchar(50),
	correo_electronico varchar(50),
	telefono varchar(50),
	prioridad varchar(2),
	fecha_hora_area_espera datetime,
	efermedades_cronicas varchar (500),
	id_primera_cita int
);

CREATE TABLE PRIMERA_CITA(
	id_primera_cita int IDENTITY(1,1) primary key not null,
	fecha_hora datetime,
	id_lugar_vacunacion int,
	id_segunda_cita int
);

CREATE TABLE LUGAR_VACUNACION(
	id_lugar_vacunacion int primary key not null,
	lugar_vacunacion varchar(50)
);

CREATE TABLE EFECTO_SECUNDARIO(
	id_efecto_secundario int IDENTITY(1,1) primary key not null,
	id_primera_cita int,
	tiempo int,
	efecto_secundario varchar (100)
);

CREATE TABLE SEGUNDA_CITA(
	id_segunda_cita int IDENTITY(1,1) primary key not null,
	fecha_hora datetime,
	id_lugar_vacunacion int,
	id_primera_cita int
);

ALTER TABLE REGISTRO
ADD CONSTRAINT FK_REGISTRO_GESTOR
FOREIGN KEY (id_gestor) REFERENCES GESTOR (id_gestor);

ALTER TABLE TRABAJA
ADD CONSTRAINT FK_TRABAJA_GESTOR
FOREIGN KEY (id_gestor) REFERENCES GESTOR (id_gestor);

ALTER TABLE TRABAJA
ADD CONSTRAINT FK_TRABAJA_EMPLEADO
FOREIGN KEY (id_empleado) REFERENCES EMPLEADO (id_empleado);

ALTER TABLE EMPLEADO 
ADD CONSTRAINT FK_EMPLEADO_TIPO_EMPLEADO
FOREIGN KEY (id_tipo_empleado) REFERENCES TIPO_EMPLEADO (id_tipo_empleado);

ALTER TABLE GESTION
ADD CONSTRAINT FK_GESTION_GESTOR
FOREIGN KEY (id_gestor) REFERENCES GESTOR (id_gestor);

ALTER TABLE GESTION
ADD CONSTRAINT FK_GESTION_EMPLEADO
FOREIGN KEY (id_empleado) REFERENCES EMPLEADO (id_empleado);

ALTER TABLE GESTION
ADD CONSTRAINT FK_GESTION_CABINA
FOREIGN KEY (id_cabina) REFERENCES CABINA (id_cabina);

ALTER TABLE CIUDADANO
ADD CONSTRAINT FK_CIUDADANO_GESTOR
FOREIGN KEY (id_gestor) REFERENCES GESTOR (id_gestor);

ALTER TABLE CIUDADANO
ADD CONSTRAINT FK_CIUDADANO_PRIMERA_CITA
FOREIGN KEY (id_primera_cita) REFERENCES PRIMERA_CITA (id_primera_cita);

ALTER TABLE PRIMERA_CITA
ADD CONSTRAINT FK_PRIMERA_CITA_LUGAR_VACUNACION
FOREIGN KEY (id_lugar_vacunacion) REFERENCES LUGAR_VACUNACION (id_lugar_vacunacion);

ALTER TABLE EFECTO_SECUNDARIO
ADD CONSTRAINT FK_EFECTO_SECUNDARIO_PRIMERA_CITA
FOREIGN KEY (id_primera_cita) REFERENCES PRIMERA_CITA (id_primera_cita);

ALTER TABLE SEGUNDA_CITA
ADD CONSTRAINT FK_SEGUNDA_CITA_LUGAR_VACUNACION
FOREIGN KEY (id_lugar_vacunacion) REFERENCES LUGAR_VACUNACION (id_lugar_vacunacion);

ALTER TABLE SEGUNDA_CITA
ADD CONSTRAINT FK_SEGUNDA_CITA_PRIMERA_CITA
FOREIGN KEY (id_primera_cita) REFERENCES PRIMERA_CITA (id_primera_cita);


INSERT INTO GESTOR VALUES (005, 'Carlos', 'carlos@gmail.com', 'colonia centroamerica', 'carlos22', 'arribabocajuniors');
INSERT INTO GESTOR VALUES (006, 'Juan', 'juan@gmail.com', 'colonia escalon', 'juanC', 'syntaxerror');
INSERT INTO GESTOR VALUES (007, 'Miguel', 'miguel@gmail.com', 'colonia satelite', 'miguelG', 'esquidush19');
INSERT INTO GESTOR VALUES (008, 'Daniel', 'daniel@gmail.com', 'colonia venezuela', 'danielD', 'vampiranaboi');
INSERT INTO GESTOR VALUES (009, 'Jose', 'jose@gmail.com', 'colonia universitaria', 'joseC', 'josemiguel13');

INSERT INTO TIPO_EMPLEADO VALUES (015, 'administrador');
INSERT INTO TIPO_EMPLEADO VALUES (016, 'cajera');

INSERT INTO EMPLEADO VALUES (010, 'Diego', 'diego@gmail.com', 'colonia barcelona', 015);
INSERT INTO EMPLEADO VALUES (011, 'Karla', 'karla@gmail.com', 'colonia satelite', 016);
INSERT INTO EMPLEADO VALUES (012, 'Paola', 'paola@gmail.com', 'colonia neptuno', 015);
INSERT INTO EMPLEADO VALUES (013, 'Andrea', 'andrea@gmail.com', 'colonia el pañuelo', 016);
INSERT INTO EMPLEADO VALUES (014, 'Ana', 'ana@gmail.com', 'colonia alta mira', 015);


INSERT INTO CABINA VALUES (018, 'colonia medica', '7456-8417', 'Diego', 'cabinamedica@gmail.com');
INSERT INTO CABINA VALUES (019, 'calle la mascota', '7546-8714', 'Karla', 'cabinamascota@gmail.com');
INSERT INTO CABINA VALUES (020, 'avenida los proceres', '7654-8147', 'Carlos', 'cabinaproceres@gmail.com');
INSERT INTO CABINA VALUES (021, 'avenida los heroes', '7456-8820', 'Paola', 'cabinaheroes@gmail.com');
INSERT INTO CABINA VALUES (022, 'colonia medica', '7596-8417', 'Miguel', 'cabinamedica2@gmail.com');

INSERT INTO LUGAR_VACUNACION VALUES (023, 'los heroes');
INSERT INTO LUGAR_VACUNACION VALUES (024, 'colonia medica');
INSERT INTO LUGAR_VACUNACION VALUES (025, 'los proceres');
INSERT INTO LUGAR_VACUNACION VALUES (026, 'colonia satelite');
INSERT INTO LUGAR_VACUNACION VALUES (027, 'centro de san salvador');






