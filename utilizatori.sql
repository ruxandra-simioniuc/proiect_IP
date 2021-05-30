use proiect_ip;
drop table utilizatori;
CREATE TABLE IF NOT EXISTS utilizatori(id INT(4) AUTO_INCREMENT PRIMARY KEY, mail VARCHAR(255) UNIQUE KEY, parola VARCHAR(255) NOT NULL, nume VARCHAR(255) NOT NULL, prenume VARCHAR(255) NOT NULL);
ALTER TABLE proiect_ip.utilizatori ADD CONSTRAINT chk_email CHECK(mail LIKE '%_@__%.__%');
INSERT INTO proiect_ip.utilizatori (mail,parola,nume,prenume) VALUES("colipcateodor@gmail.com","mama","Colipca","Teodor");
INSERT INTO proiect_ip.utilizatori (mail,parola,nume,prenume) VALUES("neculaclaudiu@gmail.com","tata","Necula","Claudiu");