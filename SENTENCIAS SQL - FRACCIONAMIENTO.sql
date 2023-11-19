CONNECT system/admin
CREATE USER fraccionamiento IDENTIFIED BY fraccionamiento;
GRANT connect, resource TO fraccionamiento;
CONNECT fraccionamiento/fraccionamiento

CREATE TABLE Empresa (
  id_empresa NUMERIC(5) NOT NULL,
  nombre_empr VARCHAR(20) NOT NULL,
  rfc_empr VARCHAR(13) NOT NULL,
  direccion_empr VARCHAR(25) NOT NULL,
  num_direccion VARCHAR(7) NOT NULL,
  cod_postal_empr VARCHAR(7) NOT NULL,
  telefono_empr VARCHAR(14) NOT NULL,
  correo_empr VARCHAR(25) NULL,
  pag_web VARCHAR(25) NULL,
  CONSTRAINT pk_idEmpresa PRIMARY KEY (id_empresa),
  CONSTRAINT uk_rfcEmpresa UNIQUE (rfc_empr),
  CONSTRAINT uk_numDireccion UNIQUE (num_direccion),
  CONSTRAINT uk_telEmpr UNIQUE (telefono_empr),
  CONSTRAINT uk_correoEmpr UNIQUE (correo_empr),
  CONSTRAINT uk_pagWeb UNIQUE (pag_web)
);

CREATE TABLE Horario_laboral (
  id_horario NUMERIC(5) NOT NULL,
  turno_matutino CHAR(1) NOT NULL,
  turno_vespertino CHAR(1) NOT NULL,
  turno_nocturno CHAR(1) NOT NULL,
  hora_inicio_lab VARCHAR(5) NOT NULL,
  hora_fin_lab VARCHAR(5) NOT NULL,
  CONSTRAINT pk_idHorario PRIMARY KEY (id_horario),
  CONSTRAINT ck_turnoMat CHECK(turno_matutino IN('S','N')),
  CONSTRAINT ck_turnoVesp CHECK(turno_vespertino IN('S','N')),
  CONSTRAINT ck_turnoNoct CHECK(turno_nocturno IN('S','N'))
  --CONSTRAINT ck_horaSalida CHECK(hora_inicio_lab < hora_fin_lab)
);

CREATE TABLE Genero (
  id_genero NUMERIC(5) NOT NULL,
  genero VARCHAR(15) NOT NULL,
  CONSTRAINT pk_idGenero PRIMARY KEY (id_genero),
  CONSTRAINT uk_genero UNIQUE (genero)
);

CREATE TABLE Color (
  id_color NUMERIC(5) NOT NULL,
  color VARCHAR(15) NOT NULL,
  CONSTRAINT pk_idColor PRIMARY KEY (id_color),
  CONSTRAINT uk_color UNIQUE (color)
);

CREATE TABLE Vivienda (
  id_vivienda NUMERIC(5) NOT NULL,
  direccion_vivienda VARCHAR(20) NOT NULL,
  numero_vivienda VARCHAR(7) NOT NULL,
  cod_postal_vivienda VARCHAR(7) NOT NULL,
  CONSTRAINT pk_idVivienda PRIMARY KEY (id_vivienda),
  CONSTRAINT uk_numViv UNIQUE (numero_vivienda)
);


CREATE TABLE Visitante (
  id_visitante NUMERIC(5) NOT NULL,
  id_genero NUMERIC(5) NOT NULL,
  nombre_vis VARCHAR(20) NOT NULL,
  paterno_vis VARCHAR(15) NOT NULL,
  materno_vis VARCHAR(15) NOT NULL,
  telefono_vis VARCHAR(13) NULL,
  ine_vis VARCHAR(13) NOT NULL,
  CONSTRAINT pk_idVisitante PRIMARY KEY (id_visitante),
  CONSTRAINT fk_idGenerVis FOREIGN KEY (id_genero) REFERENCES Genero(id_genero),
  CONSTRAINT uk_telVis UNIQUE (telefono_vis),
  CONSTRAINT uk_ineVis UNIQUE (ine_vis)
);

CREATE TABLE Empleado (
  id_empleado NUMERIC(5) NOT NULL,
  id_genero NUMERIC(5) NOT NULL,
  id_horario NUMERIC(5) NOT NULL,
  id_empresa NUMERIC(5) NOT NULL,
  nombre_empl VARCHAR(20) NOT NULL,
  paterno_empl VARCHAR(15) NOT NULL,
  materno_empl VARCHAR(15) NOT NULL,
  telefono_empl VARCHAR(13) NOT NULL,
  ine_empl VARCHAR(13) NOT NULL,
  sueldo NUMERIC(5) NOT NULL,
  contrasena VARCHAR(15) NOT NULL,
  CONSTRAINT pk_idEmpleado PRIMARY KEY (id_empleado),
  CONSTRAINT fk_idGenerEmpl FOREIGN KEY (id_genero) REFERENCES Genero(id_genero),
  CONSTRAINT fk_idHorarioEmpl FOREIGN KEY (id_horario) REFERENCES Horario_laboral(id_horario),
  CONSTRAINT fk_idEmpresaEmpl FOREIGN KEY (id_empresa) REFERENCES Empresa(id_empresa),
  CONSTRAINT uk_telEmpl UNIQUE (telefono_empl),
  CONSTRAINT uk_ineEmpl UNIQUE (ine_empl),
  CONSTRAINT ck_sueldoEmpl CHECK(sueldo >= 100)
);

CREATE TABLE Habitante (
  id_habitante NUMERIC(5) NOT NULL,
  id_genero NUMERIC(5) NOT NULL,
  id_vivienda NUMERIC(5) NOT NULL,
  nombre_hab VARCHAR(20) NOT NULL,
  paterno_hab VARCHAR(15) NOT NULL,
  materno_hab VARCHAR(15) NOT NULL,
  telefono_hab VARCHAR(13) NOT NULL,
  fecha_nacimiento DATE NOT NULL,
  ine_hab VARCHAR(13) NOT NULL,
  CONSTRAINT pk_idHabitante PRIMARY KEY (id_habitante),
  CONSTRAINT fk_idGenerHab FOREIGN KEY (id_genero) REFERENCES Genero(id_genero),
  CONSTRAINT fk_idVivHab FOREIGN KEY (id_vivienda) REFERENCES Vivienda(id_vivienda),
  CONSTRAINT uk_telHab UNIQUE (telefono_hab),
  CONSTRAINT uk_ineHab UNIQUE (ine_hab)
);

CREATE TABLE Vehiculo (
  id_vehiculo NUMERIC(5) NOT NULL,
  id_color NUMERIC(5) NOT NULL,
  id_habitante NUMERIC(5) NULL,
  id_visitante NUMERIC(5) NULL,
  matricula VARCHAR(7) NOT NULL,
  marca VARCHAR(15) NOT NULL,
  dueno_HabVis VARCHAR(9) NOT NULL,
  CONSTRAINT pk_idVehiculo PRIMARY KEY (id_vehiculo),
  CONSTRAINT fk_idColor FOREIGN KEY (id_color) REFERENCES Color(id_color),
  CONSTRAINT fk_idHabVeh FOREIGN KEY (id_habitante) REFERENCES Habitante(id_habitante),
  CONSTRAINT fk_idVisVeh FOREIGN KEY (id_visitante) REFERENCES Visitante(id_visitante),
  CONSTRAINT uk_matricula UNIQUE (matricula),
  CONSTRAINT ck_duenoVeh CHECK(dueno_HabVis IN('HABITANTE','VISITANTE'))
);

CREATE TABLE Caseta (
  id_caseta NUMERIC(5) NOT NULL,
  id_empleado NUMERIC(5) NOT NULL,
  direccion_caseta VARCHAR(20) NOT NULL,
  nombre_caseta VARCHAR(20) NOT NULL,
  CONSTRAINT pk_idCaseta PRIMARY KEY (id_caseta),
  CONSTRAINT fk_idEmplCas FOREIGN KEY (id_empleado) REFERENCES Empleado(id_empleado),
  CONSTRAINT uk_nomCaseta UNIQUE (nombre_caseta)
);

--AGREGAR DOS ATRIBUTOS DE QUE SI ES HABIRANTE O VISITANTE
CREATE TABLE Folio (
  id_folio NUMERIC(5) NOT NULL,
  id_habitante NUMERIC(5) NULL,--PROBLEMA POR CAMPO NULO
  id_visitante NUMERIC(5) NULL,--PROBLEMA POR CAMPO NULO
  id_caseta NUMERIC(5) NOT NULL,
  id_vehiculo NUMERIC(5) NULL,
  fecha_hora_entrada DATE NOT NULL,
  fecha_hora_salida DATE NULL,
  es_Hab_Vis VARCHAR(9) NOT NULL,
  llega_en_vehiculo CHAR(4) NOT NULL,
  CONSTRAINT pk_idFolio PRIMARY KEY (id_folio),
  CONSTRAINT fk_idHabFol FOREIGN KEY (id_habitante) REFERENCES Habitante(id_habitante),
  CONSTRAINT fk_idVisFol FOREIGN KEY (id_visitante) REFERENCES Visitante(id_visitante),
  CONSTRAINT fk_idCasetFol FOREIGN KEY (id_caseta) REFERENCES Caseta(id_caseta),
  CONSTRAINT ck_fechSal CHECK(fecha_hora_salida > fecha_hora_entrada),
  CONSTRAINT ck_esHabVis CHECK(es_Hab_Vis IN('HABITANTE','VISITANTE')),
  CONSTRAINT ck_llegaVehCam CHECK(llega_en_vehiculo IN('SI','OTRO'))
);


----REGISTRO DE LA TABLA EMPRESA
INSERT INTO Empresa(id_empresa, nombre_empr, rfc_empr, direccion_empr, num_direccion, cod_postal_empr, telefono_empr, correo_empr, pag_web)
VALUES (1, 'SOURCE OF WORK', 'SOW1322598345', 'AV. VENUSTIANO C', '7985', '25000', '8444389500', 'INFO@SOWORK.COM', 'WWW.SOWORK.COM');

INSERT INTO Empresa(id_empresa, nombre_empr, rfc_empr, direccion_empr, num_direccion, cod_postal_empr, telefono_empr, correo_empr, pag_web)
VALUES (2, 'BAPC CORP.', 'BAPC394762534', 'SANTA FE', '2854', '25000', '4426208720', 'INFO@BAPC.COM', 'WWW.BAPC.COM');

----REGISTRO DE LOS GENEROS
INSERT INTO Genero(id_genero, genero) VALUES (1, 'FEMENINO');
INSERT INTO Genero(id_genero, genero) VALUES (2, 'MASCULINO');
INSERT INTO Genero(id_genero, genero) VALUES (3, 'NO BINARIO');


----REGISTRO DE LOS HORARIOS
INSERT INTO Horario_laboral(id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab)
VALUES (1, 'S', 'N', 'N', '06:00', '14:00');

INSERT INTO Horario_laboral(id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab)
VALUES (2, 'N', 'S', 'N', '14:00', '22:00');

INSERT INTO Horario_laboral(id_horario, turno_matutino, turno_vespertino, turno_nocturno, hora_inicio_lab, hora_fin_lab)
VALUES (3, 'N', 'N', 'S', '22:00', '06:00');


----REGISTRO DEL EMPLEADO ADMINISTRADOR
INSERT INTO Empleado(id_empleado, id_genero, id_horario, id_empresa, nombre_empl, paterno_empl, materno_empl, telefono_empl, ine_empl, sueldo, contrasena)
VALUES (1, 2, 1, 1, 'BRANDON ALEXIS', 'PRADO', 'CASTRO', '4426208729', 'INE-BRANDON', 15000, 'brandon');

INSERT INTO Empleado(id_empleado, id_genero, id_horario, id_empresa, nombre_empl, paterno_empl, materno_empl, telefono_empl, ine_empl, sueldo, contrasena)
VALUES (2, 2, 2, 1, 'FERNANDO', 'CARRIZALES', 'QUIROZ', '1111111111', 'INE-FERNANDO', 15000, 'fernando');

INSERT INTO Empleado(id_empleado, id_genero, id_horario, id_empresa, nombre_empl, paterno_empl, materno_empl, telefono_empl, ine_empl, sueldo, contrasena)
VALUES (3, 2, 3, 1, 'OMAR', 'SEGURA', 'SENA', '2222222222', 'INE-OMAR', 15000, 'omar');

INSERT INTO Empleado(id_empleado, id_genero, id_horario, id_empresa, nombre_empl, paterno_empl, materno_empl, telefono_empl, ine_empl, sueldo, contrasena)
VALUES (4, 1, 1, 2, 'DANIELA', 'GOMEZ', 'PEREZ', '3333333333', 'INE-DANIELA', 15000, 'daniela');

INSERT INTO Empleado(id_empleado, id_genero, id_horario, id_empresa, nombre_empl, paterno_empl, materno_empl, telefono_empl, ine_empl, sueldo, contrasena)
VALUES (5, 3, 2, 1, 'MARIE', 'HERRERA', 'RIOS', '4444444444', 'INE-MARIE', 15000, 'marie');

INSERT INTO Empleado(id_empleado, id_genero, id_horario, id_empresa, nombre_empl, paterno_empl, materno_empl, telefono_empl, ine_empl, sueldo, contrasena)
VALUES (6, 1, 3, 2, 'ERIKA', 'FLORES', 'ROSALES', '6666666666', 'INE-ERIKA', 15000, 'erika');


--REGISTRO DE VIVIENDAS
INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (1, 'COL SIEMPRE VIVA', '100', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (2, 'COL SIEMPRE VIVA', '101', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (3, 'COL SIEMPRE VIVA', '102', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (4, 'COL SIEMPRE VIVA', '103', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (5, 'COL COCOS', '200', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (6, 'COL COCOS', '201', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (7, 'COL COCOS', '202', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (8, 'COL COCOS', '203', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (9, 'COL JUPITER', '301', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (10, 'COL JUPITER', '302', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (11, 'COL JUPITER', '303', '25000');

INSERT INTO Vivienda(id_vivienda, direccion_vivienda, numero_vivienda, cod_postal_vivienda)
VALUES (12, 'COL JUPITER', '304', '25000');


---INSERTAR UN COLOR
INSERT INTO Color(id_color, color) VALUES (1, 'VERDE');
INSERT INTO Color(id_color, color) VALUES (2, 'AZUL');
INSERT INTO Color(id_color, color) VALUES (3, 'ROJO');
INSERT INTO Color(id_color, color) VALUES (4, 'NEGRO');
INSERT INTO Color(id_color, color) VALUES (5, 'GRIS');
INSERT INTO Color(id_color, color) VALUES (6, 'MORADO');
INSERT INTO Color(id_color, color) VALUES (7, 'BLANCO');
INSERT INTO Color(id_color, color) VALUES (8, 'AMARILLO');
INSERT INTO Color(id_color, color) VALUES (9, 'NARANJA');
INSERT INTO Color(id_color, color) VALUES (10, 'CAFE');


--INSERTAR HABITANTES
INSERT INTO Habitante(id_habitante, id_genero, id_vivienda, nombre_hab, paterno_hab, materno_hab, telefono_hab, fecha_nacimiento, ine_hab)
VALUES (1, 1, 1, 'MARIA', 'NUÑEZ', 'ALVARADO', '8421526895', TO_DATE('02-05-2000', 'DD-MM-YYYY'), 'INE-MARIA');

INSERT INTO Habitante(id_habitante, id_genero, id_vivienda, nombre_hab, paterno_hab, materno_hab, telefono_hab, fecha_nacimiento, ine_hab)
VALUES (2, 2, 2, 'PABLO', 'MARTÍNEZ', 'GONZÁLEZ', '8442685964', TO_DATE('19-09-1999', 'DD-MM-YYYY'), 'INE-PABLO');

INSERT INTO Habitante(id_habitante, id_genero, id_vivienda, nombre_hab, paterno_hab, materno_hab, telefono_hab, fecha_nacimiento, ine_hab)
VALUES (3, 2, 2, 'ALEXANDER', 'SANCHEZ', 'ALVARADO', '4458756985', TO_DATE('28-01-2002', 'DD-MM-YYYY'), 'INE-ALEXANDER');

INSERT INTO Habitante(id_habitante, id_genero, id_vivienda, nombre_hab, paterno_hab, materno_hab, telefono_hab, fecha_nacimiento, ine_hab)
VALUES (4, 3, 1, 'DANIELE', 'PEREZ', 'ROCHA', '9856201458', TO_DATE('25-06-1980', 'DD-MM-YYYY'), 'INE-DANIELE');

--INSERTAR VISITANTES
INSERT INTO Visitante(id_visitante, id_genero, nombre_vis, paterno_vis, materno_vis, telefono_vis, ine_vis)
VALUES (1, 2, 'JOSE', 'FLORES', 'ORTA', '8426521450', 'INE-JOSE');

INSERT INTO Visitante(id_visitante, id_genero, nombre_vis, paterno_vis, materno_vis, telefono_vis, ine_vis)
VALUES (2, 1, 'FATIMA', 'MORALES', 'LEURA', '8442125459', 'INE-FATIMA');

INSERT INTO Visitante(id_visitante, id_genero, nombre_vis, paterno_vis, materno_vis, telefono_vis, ine_vis)
VALUES (3, 2, 'RAUL', 'PEÑA', 'CORTES', '8429654852', 'INE-RAUL');


---INSERTAR UN AUTOMOVIL
INSERT INTO Vehiculo(id_vehiculo, id_color, id_habitante, id_visitante, matricula, marca, dueno_HabVis) 
VALUES (1, 1, 1, null, 'MTK2345', 'LEXUS', 'HABITANTE');

INSERT INTO Vehiculo(id_vehiculo, id_color, id_habitante, id_visitante, matricula, marca, dueno_HabVis) 
VALUES (2, 5, null, 2,'VLP2378', 'CHEVROLET', 'VISITANTE');

INSERT INTO Vehiculo(id_vehiculo, id_color, id_habitante, id_visitante, matricula, marca, dueno_HabVis) 
VALUES (3, 3, 1, null, 'BVH9938', 'VW', 'HABITANTE');

INSERT INTO Vehiculo(id_vehiculo, id_color, id_habitante, id_visitante, matricula, marca, dueno_HabVis) 
VALUES (4, 2, null, 2, 'GHY2342', 'CHEVROLET', 'VISITANTE');

INSERT INTO Vehiculo(id_vehiculo, id_color, id_habitante, id_visitante, matricula, marca, dueno_HabVis) 
VALUES (5, 1, 2, null, 'BVF4368', 'FIAT', 'HABITANTE');


--INSERTAR CASETAS
INSERT INTO Caseta(id_caseta, id_empleado, direccion_caseta, nombre_caseta)
VALUES (1, 1, 'AV. V CARRANZA', 'ZONA NORTE MAT');

INSERT INTO Caseta(id_caseta, id_empleado, direccion_caseta, nombre_caseta)
VALUES (2, 2, 'AV. V CARRANZA', 'ZONA NORTE VESP');

INSERT INTO Caseta(id_caseta, id_empleado, direccion_caseta, nombre_caseta)
VALUES (3, 3, 'AV. V CARRANZA', 'ZONA NORTE NOCT');

INSERT INTO Caseta(id_caseta, id_empleado, direccion_caseta, nombre_caseta)
VALUES (4, 4, 'AV. FRANCISCO COSS', 'ZONA SUR MAT');

INSERT INTO Caseta(id_caseta, id_empleado, direccion_caseta, nombre_caseta)
VALUES (5, 5, 'AV. FRANCISCO COSS', 'ZONA SUR VESP');

INSERT INTO Caseta(id_caseta, id_empleado, direccion_caseta, nombre_caseta)
VALUES (6, 6, 'AV. FRANCISCO COSS', 'ZONA SUR NOCT');


--INSERTAR FOLIOS ****CAMBIAR A 24 HRS y AGREGAR FECHA ***AGREGAR DOS ATRIBUTOS DE QUE SI ES VISITANTE O HABITANTE
INSERT INTO Folio(id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo)
VALUES (1, null, 1, 1, 1,  SYSDATE, NULL, 'VISITANTE', 'SI');

INSERT INTO Folio(id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo)
VALUES (2, 1, null, 2, 2, SYSDATE, NULL, 'HABITANTE', 'SI');

INSERT INTO Folio(id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo)
VALUES (3, 3, null, 2, 4, SYSDATE, NULL, 'HABITANTE', 'SI');

INSERT INTO Folio(id_folio, id_habitante, id_visitante, id_caseta, id_vehiculo, fecha_hora_entrada, fecha_hora_salida, es_Hab_Vis, llega_en_vehiculo)
VALUES (4, 2, null, 2, 4, SYSDATE, NULL, 'HABITANTE', 'SI');


