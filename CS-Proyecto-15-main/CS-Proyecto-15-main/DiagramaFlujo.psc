Algoritmo NivelPostulante
	Leer cantidadPreguntas
	Leer cantidadCorrectas
	porcentaje = (cantidadCorrectas * 100) / canitdadPreguntas
	Si porcentaje >= 90 Entonces
		Escribir "Nivel Maximo"
	SiNo
		Si porcentaje >= 75 Entonces
			Escribir "Nivel Medio"
		SiNo
			Si porcentaje >= 50 Entonces
				Escribir "Nivel Regular"
			SiNo
				Escribir "Fuera del Nivel"
			FinSi
		FinSi
	FinSi
FinAlgoritmo
