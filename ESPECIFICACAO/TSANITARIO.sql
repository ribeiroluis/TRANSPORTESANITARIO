SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `TRANSPORTESANITARIOBD` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `TRANSPORTESANITARIOBD` ;

-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_BAIRRO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_BAIRRO` (
  `idBAIRO` INT NOT NULL,
  `NOME_BAIRRO` VARCHAR(100) NULL,
  PRIMARY KEY (`idBAIRO`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_CIDADE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_CIDADE` (
  `idCIDADE` INT NOT NULL,
  `NOME_CIDADE` VARCHAR(100) NULL,
  `UF_CIDADE` VARCHAR(2) NULL,
  PRIMARY KEY (`idCIDADE`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_CEP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_CEP` (
  `CEP` INT NOT NULL,
  `LOGRADOURO_CEP` VARCHAR(200) NULL,
  `TB_BAIRRO_idBAIRO` INT NOT NULL,
  `TB_CIDADE_idCIDADE` INT NOT NULL,
  PRIMARY KEY (`CEP`),
  INDEX `fk_TB_CEP_TB_BAIRRO_idx` (`TB_BAIRRO_idBAIRO` ASC),
  INDEX `fk_TB_CEP_TB_CIDADE1_idx` (`TB_CIDADE_idCIDADE` ASC),
  CONSTRAINT `fk_TB_CEP_TB_BAIRRO`
    FOREIGN KEY (`TB_BAIRRO_idBAIRO`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_BAIRRO` (`idBAIRO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_CEP_TB_CIDADE1`
    FOREIGN KEY (`TB_CIDADE_idCIDADE`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_CIDADE` (`idCIDADE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = '				';


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_PACIENTE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_PACIENTE` (
  `idPACIENTE` INT NOT NULL,
  `NOME_PACIENTE` VARCHAR(100) NULL,
  `SEXO_PACIENTE` VARCHAR(1) NULL,
  `IDADE_PACIENTE` INT NULL,
  `HISTORICO_PACIENTE` VARCHAR(200) NULL,
  `TB_CEP_CEP` INT NOT NULL,
  `NUMERO_PACIENTE` INT NULL,
  `COMPLEMENTO_PACIENTE` VARCHAR(10) NULL,
  `PONTOREFERENCIA_PACIENTE` VARCHAR(200) NULL,
  `TELEFONE1_PACIENTE` VARCHAR(10) NULL,
  `TELEFONE2_PACIENTE` VARCHAR(10) NULL,
  PRIMARY KEY (`idPACIENTE`),
  INDEX `fk_TB_PACIENTE_TB_CEP1_idx` (`TB_CEP_CEP` ASC),
  CONSTRAINT `fk_TB_PACIENTE_TB_CEP1`
    FOREIGN KEY (`TB_CEP_CEP`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_CEP` (`CEP`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_ESTABELICIMENTO_SAUDE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_ESTABELICIMENTO_SAUDE` (
  `idESTABELICIMENTO_SAUDE` INT NOT NULL,
  `NOME_ESTABELECIMENTO` VARCHAR(45) NULL,
  `TB_CEP_CEP` INT NOT NULL,
  `NUMERO_ESTABELECIMENTO` INT NULL,
  `COMPLEMENTO_ESTABELECIMENTO` VARCHAR(10) NULL,
  `PONTOREFERENCIA_ESTABELECIMENTO` VARCHAR(100) NULL,
  `TELEFONE1_ESTABELECIMENTO` VARCHAR(10) NULL,
  `TELEFONE2_ESTABELECIMENTO` VARCHAR(10) NULL,
  PRIMARY KEY (`idESTABELICIMENTO_SAUDE`),
  INDEX `fk_TB_ESTABELICIMENTO_SAUDE_TB_CEP1_idx` (`TB_CEP_CEP` ASC),
  CONSTRAINT `fk_TB_ESTABELICIMENTO_SAUDE_TB_CEP1`
    FOREIGN KEY (`TB_CEP_CEP`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_CEP` (`CEP`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_FUNCIONARIO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_FUNCIONARIO` (
  `MATRICULA_FUNCIONARIO` INT NOT NULL,
  `NOME_FUNCIONARIO` VARCHAR(100) NULL,
  `TELEFONEFIXO_FUNCIONARIO` VARCHAR(10) NULL,
  `TELEFONECELULAR_FUNCIONARIO` VARCHAR(10) NULL,
  `TB_CEP_CEP` INT NOT NULL,
  `NUMERO_FUNCIONARIO` INT NULL,
  `COMPLEMENTO_FUNCIONARIO` VARCHAR(10) NULL,
  `APELIDO_FUNCIONARIO` VARCHAR(45) NULL,
  PRIMARY KEY (`MATRICULA_FUNCIONARIO`),
  INDEX `fk_TB_FUNCIONARIO_TB_CEP1_idx` (`TB_CEP_CEP` ASC),
  CONSTRAINT `fk_TB_FUNCIONARIO_TB_CEP1`
    FOREIGN KEY (`TB_CEP_CEP`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_CEP` (`CEP`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = '				';


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_AMBULANCIA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_AMBULANCIA` (
  `NUMERO_AMBULANCIA` INT NOT NULL,
  `MODELO_AMBULANCIA` VARCHAR(45) NULL,
  `ANO_AMBULANCIA` INT NULL,
  PRIMARY KEY (`NUMERO_AMBULANCIA`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_EMPENHO_AMBULANCIA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_EMPENHO_AMBULANCIA` (
  `idEMPENHO_AMBULANCIA` INT NOT NULL,
  `TB_AMBULANCIA_NUMERO_AMBULANCIA` INT NOT NULL,
  `DATA_EMPENHO_AMBULANCIA` DATE NULL,
  `HORAINICIO_EMPENHO_AMBULANCIA` TIME NULL,
  `HORAFIM_EMPENHO_AMBULANCIA` TIME NULL,
  `TB_FUNCIONARIO_MATRICULA_FUNCIONARIO_MOTORISTA` INT NOT NULL,
  `TB_FUNCIONARIO_MATRICULA_FUNCIONARIO_TECENFERMAGEM` INT NOT NULL,
  `STATUS_EMPENHO_AMBULANCIA` TINYINT(1) NULL COMMENT 'RETORNA\nTRUE - SE DISPONIVEL\nFALSE - SE OCUPADO',
  `OBSERVACAO_EMPENHO_AMBULANCIA` VARCHAR(100) NULL,
  PRIMARY KEY (`idEMPENHO_AMBULANCIA`),
  INDEX `fk_TB_EMPENHO_AMBULANCIA_TB_AMBULANCIA1_idx` (`TB_AMBULANCIA_NUMERO_AMBULANCIA` ASC),
  INDEX `fk_TB_EMPENHO_AMBULANCIA_TB_FUNCIONARIO1_idx` (`TB_FUNCIONARIO_MATRICULA_FUNCIONARIO_MOTORISTA` ASC),
  INDEX `fk_TB_EMPENHO_AMBULANCIA_TB_FUNCIONARIO2_idx` (`TB_FUNCIONARIO_MATRICULA_FUNCIONARIO_TECENFERMAGEM` ASC),
  CONSTRAINT `fk_TB_EMPENHO_AMBULANCIA_TB_AMBULANCIA1`
    FOREIGN KEY (`TB_AMBULANCIA_NUMERO_AMBULANCIA`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_AMBULANCIA` (`NUMERO_AMBULANCIA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_EMPENHO_AMBULANCIA_TB_FUNCIONARIO1`
    FOREIGN KEY (`TB_FUNCIONARIO_MATRICULA_FUNCIONARIO_MOTORISTA`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_FUNCIONARIO` (`MATRICULA_FUNCIONARIO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_EMPENHO_AMBULANCIA_TB_FUNCIONARIO2`
    FOREIGN KEY (`TB_FUNCIONARIO_MATRICULA_FUNCIONARIO_TECENFERMAGEM`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_FUNCIONARIO` (`MATRICULA_FUNCIONARIO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_EMPENHO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_EMPENHO` (
  `idEMPENHO` INT NOT NULL,
  `HORARIO_EMPENHO` TIME NULL,
  `DATA_EMPENHO` DATE NULL,
  `EVOLUCAO_EMPENHO` VARCHAR(200) NULL,
  `TB_EMPENHO_AMBULANCIA_idEMPENHO_AMBULANCIA` INT NOT NULL,
  PRIMARY KEY (`idEMPENHO`),
  INDEX `fk_TB_EMPENHO_TB_EMPENHO_AMBULANCIA1_idx` (`TB_EMPENHO_AMBULANCIA_idEMPENHO_AMBULANCIA` ASC),
  CONSTRAINT `fk_TB_EMPENHO_TB_EMPENHO_AMBULANCIA1`
    FOREIGN KEY (`TB_EMPENHO_AMBULANCIA_idEMPENHO_AMBULANCIA`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_EMPENHO_AMBULANCIA` (`idEMPENHO_AMBULANCIA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_ATENDIMENTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_ATENDIMENTO` (
  `idATENDIMENTO` INT NOT NULL,
  `HORARIO_ATENDIMENTO` TIME NULL,
  `DATA_ATENDIMENTO` DATE NULL,
  `HORACONSULTA_ATENDIMENTO` TIME NULL,
  `DATACONSULTA_ATENDIMENTO` DATE NULL,
  `ESTABELECIMENTOorigem_ATENDIMENTO` INT NOT NULL,
  `ESTABELECIMENTOdestino_ATENDIMENTO` INT NOT NULL,
  `PACIENTEorigem_ATENDIMENTO` INT NOT NULL,
  `PACIENTEdestino_ATENDIMENTO` INT NOT NULL,
  `PADISTOLICA_ATENDIMENTO` INT NULL,
  `PASISTOLICA_ATENDIMENTO` INT NULL,
  `FREQUENCIACARDIACA_ATENDIMENTO` INT NULL,
  `FREQUENCIARESPIRATORIA_ATENDIMENTO` INT NULL,
  `TEMPERATURA_ATENDIMENTO` INT NULL,
  `SATURACAO_ATENDIMENTO` INT NULL,
  `TB_FUNCIONARIO_MATRICULA_FUNCIONARIORESPONSAVEL` INT NOT NULL,
  `TB_EMPENHO_idEMPENHO` INT NOT NULL,
  `STATUS_ATENDIMENTO` VARCHAR(45) NULL COMMENT 'RETORNA O STATUS DO ATENDIMENTO:\nCANCELADO\nREALIZADO\nAGUARDANDO',
  PRIMARY KEY (`idATENDIMENTO`),
  INDEX `fk_TB_ATENDIMENTO_TB_ESTABELICIMENTO_SAUDE1_idx` (`ESTABELECIMENTOorigem_ATENDIMENTO` ASC),
  INDEX `fk_TB_ATENDIMENTO_TB_ESTABELICIMENTO_SAUDE2_idx` (`ESTABELECIMENTOdestino_ATENDIMENTO` ASC),
  INDEX `fk_TB_ATENDIMENTO_TB_PACIENTE1_idx` (`PACIENTEorigem_ATENDIMENTO` ASC),
  INDEX `fk_TB_ATENDIMENTO_TB_PACIENTE2_idx` (`PACIENTEdestino_ATENDIMENTO` ASC),
  INDEX `fk_TB_ATENDIMENTO_TB_FUNCIONARIO1_idx` (`TB_FUNCIONARIO_MATRICULA_FUNCIONARIORESPONSAVEL` ASC),
  INDEX `fk_TB_ATENDIMENTO_TB_EMPENHO1_idx` (`TB_EMPENHO_idEMPENHO` ASC),
  CONSTRAINT `fk_TB_ATENDIMENTO_TB_ESTABELICIMENTO_SAUDE1`
    FOREIGN KEY (`ESTABELECIMENTOorigem_ATENDIMENTO`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_ESTABELICIMENTO_SAUDE` (`idESTABELICIMENTO_SAUDE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_ATENDIMENTO_TB_ESTABELICIMENTO_SAUDE2`
    FOREIGN KEY (`ESTABELECIMENTOdestino_ATENDIMENTO`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_ESTABELICIMENTO_SAUDE` (`idESTABELICIMENTO_SAUDE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_ATENDIMENTO_TB_PACIENTE1`
    FOREIGN KEY (`PACIENTEorigem_ATENDIMENTO`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_PACIENTE` (`idPACIENTE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_ATENDIMENTO_TB_PACIENTE2`
    FOREIGN KEY (`PACIENTEdestino_ATENDIMENTO`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_PACIENTE` (`idPACIENTE`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_ATENDIMENTO_TB_FUNCIONARIO1`
    FOREIGN KEY (`TB_FUNCIONARIO_MATRICULA_FUNCIONARIORESPONSAVEL`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_FUNCIONARIO` (`MATRICULA_FUNCIONARIO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TB_ATENDIMENTO_TB_EMPENHO1`
    FOREIGN KEY (`TB_EMPENHO_idEMPENHO`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_EMPENHO` (`idEMPENHO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
COMMENT = '		\n\n\n\n\n';


-- -----------------------------------------------------
-- Table `TRANSPORTESANITARIOBD`.`TB_ATENDIMENTO_CANCELADO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `TRANSPORTESANITARIOBD`.`TB_ATENDIMENTO_CANCELADO` (
  `MOTIVO_ATENDIMENTO_CANCELADO` VARCHAR(100) NULL,
  `TB_ATENDIMENTO_idATENDIMENTO` INT NOT NULL,
  `DATA_ATENDIMENTO_CANCELADO` DATE NULL,
  `HORA_ATENDIMENTO_CANCELADO` TIME NULL,
  PRIMARY KEY (`TB_ATENDIMENTO_idATENDIMENTO`),
  CONSTRAINT `fk_TB_ATENDIMENTO_CANCELADO_TB_ATENDIMENTO1`
    FOREIGN KEY (`TB_ATENDIMENTO_idATENDIMENTO`)
    REFERENCES `TRANSPORTESANITARIOBD`.`TB_ATENDIMENTO` (`idATENDIMENTO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;