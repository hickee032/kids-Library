--------------------------------------------------------
--  Ref Constraints for Table LECTURE
--------------------------------------------------------

  ALTER TABLE "LECTURE" ADD CONSTRAINT "FK_LECTURE_LTNUM_MANAGER_MNUM" FOREIGN KEY ("LTNUM")
	  REFERENCES "MANAGER" ("MNUM") ENABLE;
