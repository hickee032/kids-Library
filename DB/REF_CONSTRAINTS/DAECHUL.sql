--------------------------------------------------------
--  Ref Constraints for Table DAECHUL
--------------------------------------------------------

  ALTER TABLE "DAECHUL" ADD CONSTRAINT "FK_DAECHUL_BNUM_BOOK_BNUM" FOREIGN KEY ("BNUM")
	  REFERENCES "BOOK" ("BNUM") ENABLE;
  ALTER TABLE "DAECHUL" ADD CONSTRAINT "FK_DAECHUL_CNUM_CUSTOMER_CNUM" FOREIGN KEY ("CNUM")
	  REFERENCES "CUSTOMER" ("CNUM") ENABLE;
