--------------------------------------------------------
--  DDL for Table MANAGER
--------------------------------------------------------

  CREATE TABLE "MANAGER" 
   (	"MNUM" VARCHAR2(20 BYTE), 
	"MPW" VARCHAR2(20 BYTE), 
	"MNAME" VARCHAR2(20 BYTE), 
	"MTEL" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;

   COMMENT ON COLUMN "MANAGER"."MNUM" IS '�����ڹ�ȣ';
   COMMENT ON COLUMN "MANAGER"."MPW" IS '�����ں��';
   COMMENT ON COLUMN "MANAGER"."MNAME" IS '�������̸�';
   COMMENT ON COLUMN "MANAGER"."MTEL" IS '�����ڿ���ó';
   COMMENT ON TABLE "MANAGER"  IS '����������';