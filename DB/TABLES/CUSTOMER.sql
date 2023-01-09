--------------------------------------------------------
--  DDL for Table CUSTOMER
--------------------------------------------------------

  CREATE TABLE "CUSTOMER" 
   (	"CNUM" VARCHAR2(20 BYTE), 
	"CPW" VARCHAR2(20 BYTE), 
	"CNAME" VARCHAR2(20 BYTE), 
	"CAGE" VARCHAR2(20 BYTE), 
	"CGEN" VARCHAR2(20 BYTE), 
	"CTEL" VARCHAR2(20 BYTE), 
	"CLAST" VARCHAR2(20 BYTE), 
	"CTYPE" VARCHAR2(20 BYTE), 
	"PNUM" VARCHAR2(20 BYTE), 
	"TNUM" VARCHAR2(20 BYTE), 
	"CSCHOOL" VARCHAR2(50 BYTE), 
	"CINT" VARCHAR2(20 BYTE), 
	"LNUM" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;

   COMMENT ON COLUMN "CUSTOMER"."CNUM" IS 'ȸ����ȣ';
   COMMENT ON COLUMN "CUSTOMER"."CPW" IS 'ȸ�����';
   COMMENT ON COLUMN "CUSTOMER"."CNAME" IS 'ȸ���̸�';
   COMMENT ON COLUMN "CUSTOMER"."CAGE" IS 'ȸ������';
   COMMENT ON COLUMN "CUSTOMER"."CGEN" IS 'ȸ������';
   COMMENT ON COLUMN "CUSTOMER"."CTEL" IS 'ȸ������ó';
   COMMENT ON COLUMN "CUSTOMER"."CLAST" IS '������������';
   COMMENT ON COLUMN "CUSTOMER"."CTYPE" IS 'ȸ��Ÿ��';
   COMMENT ON COLUMN "CUSTOMER"."PNUM" IS '�θ��ȣ';
   COMMENT ON COLUMN "CUSTOMER"."TNUM" IS '�����Թ�ȣ';
   COMMENT ON COLUMN "CUSTOMER"."CSCHOOL" IS '�Ҽ�';
   COMMENT ON COLUMN "CUSTOMER"."CINT" IS '���ɻ�';
   COMMENT ON COLUMN "CUSTOMER"."LNUM" IS '���¹�ȣ';
   COMMENT ON TABLE "CUSTOMER"  IS 'ȸ������';