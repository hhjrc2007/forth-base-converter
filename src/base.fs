: binary ( -- ) 2 base ! ;
: octal ( -- ) 8 base ! ;

: with-base ( n xt base -- ) base @ >r base ! execute r> base ! ;

: .base ( n base -- ) ['] . swap with-base ;
: u.base ( u base -- ) ['] u. swap with-base ;

: .bin ( n -- ) 2 .base ;
: .oct ( n -- ) 8 .base ;
: .dec ( n -- ) 10 .base ;
: .hex ( n -- ) 16 .base ;

