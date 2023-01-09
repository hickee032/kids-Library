--------------------------------------------------------
--  Constraints for Table LECTURE
--------------------------------------------------------

  ALTER TABLE "LECTURE" MODIFY ("LNUM" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" MODIFY ("LNAME" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" MODIFY ("LLOC" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" MODIFY ("LTAR" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" MODIFY ("LPER" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" MODIFY ("LTIME" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" MODIFY ("LDAY" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" MODIFY ("LTNUM" NOT NULL ENABLE);
  ALTER TABLE "LECTURE" ADD PRIMARY KEY ("LNUM")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;