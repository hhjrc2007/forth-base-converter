include base.fs

: read-num ( "number" -- n flag ) parse-name s>number? >r drop r> ;
: read-base ( base "number" -- n )
	base @ >r base ! read-num r> base ! 0= abort" not a number" ;

: convert-base ( from to "number" -- ) >r read-base r> .base ;
