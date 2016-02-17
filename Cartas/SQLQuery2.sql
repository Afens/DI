SELECT Nombre FROM Carta WHERE nombre like '%%' AND nombre not IN (SELECT nombreCarta FROM tiene where nombreUsuario='a')
