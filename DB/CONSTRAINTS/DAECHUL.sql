--------------------------------------------------------
--  Constraints for Table DAECHUL
--------------------------------------------------------

  ALTER TABLE "DAECHUL" MODIFY ("DNUM" NOT NULL ENABLE);
  ALTER TABLE "DAECHUL" MODIFY ("CNUM" NOT NULL ENABLE);
  ALTER TABLE "DAECHUL" MODIFY ("BNUM" NOT NULL ENABLE);
  ALTER TABLE "DAECHUL" MODIFY ("DDATE" NOT NULL ENABLE);
  ALTER TABLE "DAECHUL" MODIFY ("DRETURN" NOT NULL ENABLE);
  ALTER TABLE "DAECHUL" ADD PRIMARY KEY ("DNUM")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;