# UniversityManagementWithEf

Esercizio di Riepilogo Web Api Rest - EF
- Creare le seguenti entità in relazione (NOMI IN INGLESE):
	§ Corso di Laurea
		# Id
		# Titolo
		# Annualità (inteso come anno di inizio)
		# Studenti
	§ Esame
		# Id
		# Titolo
		# NumCrediti (3, 6, 12 o 15 crediti)
		# Docenti
		# Id Corso
	§ Risultato Esame
		# Id Esame
		# Id Studente
		# Valutazione (Min 18, Max 31 => Vale come 30eLode)
	§ Studente
		# Id (Vale come matricola)
		# Nome
		# Cognome
		# Codice Fiscale (Deve essere un CF)
		# Data di Nascita (Deve avere almeno 18 anni)
		# Corsi di Laurea (NB: CORSI, non CORSO)
		# Libretto (Elenco di Risultati Esami)
	§ Docente
		# Id
		# Nome
		# Cognome
		# Codice Fiscale (Deve essere un CF)
		# Data di Nascita (Deve avere almeno 18 anni)
		# Esami
- Creare i modelli relativi con la validazione necessaria
- Creare le CRUD relative con le seguenti aggiunte:
	§ Esami
		# Funzionalità POST che consenta la copia di un esame da un corso di laurea a un altro
	§ Studente
		# Riepilogo del suo libretto con Titolo Esame e Voto
