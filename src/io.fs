include base.fs

: read-num ( "number" -- n ) parse-name s>number? drop drop ;
: read-base ( base "number" -- n ) base @ >r base ! read-num r> base ! ;

: convert-base ( from to "number" -- ) >r read-base r> .base ;
