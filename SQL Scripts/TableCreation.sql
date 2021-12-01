CREATE TABLE IF NOT EXISTS Type (
	type_name varchar(255) PRIMARY KEY
);

CREATE TABLE IF NOT EXISTS Pokemon (
    pokemon_index int,
    pokemon_name varchar(255) UNIQUE NOT NULL,
    classification varchar(255) NOT NULL,
	hp int NOT NULL,
	attack int NOT NULL,
	defense int NOT NULL,
	special int NOT NULL,
	speed int NOT NULL,
	type1 varchar(255) NOT NULL,
	type2 varchar(255),
	PRIMARY KEY (pokemon_index),
	FOREIGN KEY (type1) REFERENCES Type (type_name),
	FOREIGN KEY (type2) REFERENCES Type (type_name)
);

CREATE Table if not exists Type_Matchup(
	offensive_type varchar(255),
	defensive_type varchar(255),
	offensive_multiplier decimal(3,2) NOT NULL,
	defensive_multiplier decimal(3,2) NOT NULL,
	PRIMARY KEY (offensive_multiplier, defensive_multiplier),
	FOREIGN KEY (offensive_type) REFERENCES Type (type_name),
	FOREIGN KEY (defensive_type) REFERENCES Type (type_name)
);

CREATE TABLE if not exists Move
(
move_name VARCHAR(255) PRIMARY KEY,
attack_power INT,
accuracy DECIMAL(3,2),
pp INT NOT Null,
effect_percentage DECIMAL(3,2),
type VARCHAR(255),
FOREIGN KEY(type) REFERENCES Type(type_name)
);

CREATE TABLE IF NOT EXISTS Learn
(
pokemon_name VARCHAR(255),
move_name VARCHAR(255),
FOREIGN KEY(pokemon_name) REFERENCES Pokemon(pokemon_name),
FOREIGN KEY(move_name) REFERENCES Move(move_name),
PRIMARY KEY (pokemon_name, move_name),
learn_level INT NOT NULL
);

