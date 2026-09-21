: binary ( -- ) 2 base ! ;
: octal ( -- ) 8 base ! ;

: .base ( n base -- ) base @ >r base ! . r> base ! ;

: .bin ( n -- ) 2 .base ;
: .oct ( n -- ) 8 .base ;
: .dec ( n -- ) 10 .base ;
: .hex ( n -- ) 16 .base ;

