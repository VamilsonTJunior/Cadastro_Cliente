CREATE TABLE cadastro_de_clientes( 
	codigo INTEGER UNIQUE, 
	nome VARCHAR, 
	cnpj VARCHAR UNIQUE, 
	datacadastro DATE, 
	endereco VARCHAR, 
	telefone VARCHAR  
) 	

/

ALTER TABLE cadastro_de_clientes 
	ADD CONSTRAINT pk_clientes
	PRIMARY KEY (codigo) 
