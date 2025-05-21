INSERT INTO Rol (nombre) VALUES 
('Administrador de Red'),
('Encargado de Instalaciones'),
('Responsable de Inspecciones'),
('Analista en Sismos'),
('Analista Supervisor');
INSERT INTO Empleado (mail, idRol) VALUES 
('juan.perez@ccrs.com', 1),
('laura.instalaciones@ccrs.com', 2),
('roberto.inspecciones@ccrs.com', 3),
('carla.analista@ccrs.com', 4),
('maria.supervisora@ccrs.com', 5);
INSERT INTO EstacionSismologica (codigoEstacion, nombre) VALUES 
('ES001', 'Estación Córdoba'),
('ES002', 'Estación Salta');
INSERT INTO Sismografo (idEstacion) VALUES 
(1), -- Sismógrafo 1 en Córdoba
(2); -- Sismógrafo 2 en Salta
INSERT INTO Estado (ambito, nombreEstado) VALUES 
('Sismografo', 'EnEsperaCertificacion'),
('Sismografo', 'HabilitadoParaConstruccion'),
('Sismografo', 'Disponible'),
('Sismografo', 'IncluidoEnPlanConstruccion'),
('Sismografo', 'EnInstalacion'),
('Sismografo', 'EnLinea'),
('Sismografo', 'Reclamado'),
('Sismografo', 'InhabilitadoPorInspeccion'),
('Sismografo', 'FueraDeServicio'),
('Sismografo', 'Reclamado'),
('Sismografo', 'DadoBaja');
INSERT INTO Usuario (nombreUsuario, contraseña) VALUES
('ri.inspector', 'clave123'),                 
('admin.red', 'admin2025'),                  
('encargado.instalaciones', 'instalacion#1'), 
('analista.sismos', 'sismo_456'),             
('supervisor.sismos', 'super2025'),           
('usuario.test', 'test1234');                 


INSERT INTO OrdenInspeccion (
    nroOrden, fechaHoraInicio, fechaHoraFinalizacion, fechaHoraCierre, observacionCierre, idUsuario
) VALUES (
    1001, 
    '2025-05-01 08:00:00', 
    '2025-05-01 12:00:00', 
    '2025-05-01 13:00:00', 
    'Inspección realizada sin novedades.', 
    1
);


INSERT INTO OrdenInspeccion (
    nroOrden, fechaHoraInicio, fechaHoraFinalizacion, fechaHoraCierre, observacionCierre, idUsuario
) VALUES (
    1002, 
    '2025-05-02 09:00:00', 
    '2025-05-02 14:00:00', 
    NULL, 
    NULL, 
    1
);


INSERT INTO OrdenInspeccion (
    nroOrden, fechaHoraInicio, fechaHoraFinalizacion, fechaHoraCierre, observacionCierre, idUsuario
) VALUES (
    1003, 
    '2025-05-05 08:30:00', 
    NULL, 
    NULL, 
    NULL, 
    2
);


INSERT INTO OrdenInspeccion (
    nroOrden, fechaHoraInicio, fechaHoraFinalizacion, fechaHoraCierre, observacionCierre, idUsuario
) VALUES (
    1004, 
    '2025-05-07 10:00:00', 
    '2025-05-07 15:30:00', 
    NULL, 
    NULL, 
    2
);


INSERT INTO OrdenInspeccion (
    nroOrden, fechaHoraInicio, fechaHoraFinalizacion, fechaHoraCierre, observacionCierre, idUsuario
) VALUES (
    1005, 
    '2025-05-03 07:45:00', 
    '2025-05-03 13:15:00', 
    '2025-05-03 14:00:00', 
    'Se detectó vibración anormal en el sensor. Sismógrafo puesto fuera de servicio.', 
    3
);


