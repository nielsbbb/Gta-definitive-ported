   ц А Zљ
M Ш   љ
M Ш    ┴   I Iц ├ д   ZGц   ─       а@├шеЙ    ZHц M ┴   Ц ц       т	TEXT1 ж	љ
?M U    <   љ
M C     Ч   v     
 ц 9 ц бM     Я§  9 ц фM     Л§  9 ц └M №■   ┬§  9 ц ═M ┘■   │§  9 ц оM ├■   ц§  9 ц ПM Г■   Ћ§  9 ц жM Ќ■   є§  9 ц ЫM Ђ■   w§  9 ц M k■   h§  9 ц 	M U■   Y§  9 ц M ?■   J§  9 ц %M )■   ;§  9 ц *M ■   ,§  9 ц BM §§   §  9 ц RM у§   §   Н    ц Е Н    ц ┐ Н    ц ╠ Н    ц Н Н    ц ▄ Н    ц у Н    ц ы Н    ц   Н    ц  Н    ц  Н    ц $ Н    ц ) Н    ц A Н    ц P Н    ц А Н     ├  Ш   VAR    ONMISSION ў  PLAYER_ACTOR    PLAYER_CHAR    PLAYER_GROUP    SECOND_PLAYER џ   FLAG    SRC ║
  {$CLEO .cs}
 
 0000: NOP
 0004: $41 = 417

:WACHT
0001: wait 90
0A90: is_hid_pressed 15
004D: jump_if_false @WACHT 
0A90: is_hid_pressed 12
004D: jump_if_false @WACHT
0002: jump @START

:TRST
0249: release_model 5@
0249: release_model $41 
01C3: remove_references_to_car 5@
00A6: destroy_car 5@ 

:START
0001: wait 90 
0247: load_model $41   
0001: wait 0  
04C4: store_coords_to 1@ 2@ 3@  from_actor $PLAYER_ACTOR with_offset 0.0 5.0 -0.33
:CAR
0001: wait 90
0248:   model $41 available
004D: jump_if_false @START
00A5: 5@ = create_car $41 at 1@ 2@ 3@

:ACTION0
0001: wait 0
03E5: show_text_box 'TEXT1'
0A90: is_hid_pressed 63
004D: jump_if_false @VOL1 
0002: jump @NEXT
:VOL1  
0A90: is_hid_pressed 12
004D: jump_if_false @VOL2 
0002: jump @ENDE
:VOL2  
0002: jump @ACTION0

:NEXT 
0001: wait 0
000A: $41 += 1
0039: $41 == 418 
004D: jump_if_false @WHY
0002: jump @HHHH
:WHY
0039: $41 == 426 
004D: jump_if_false @WHY1
0002: jump @FAIL
:WHY1
0039: $41 == 448 
004D: jump_if_false @WHY2
0002: jump @FAIL2
:WHY2
0039: $41 == 461 
004D: jump_if_false @WHY3
0002: jump @FAIL3
:WHY3
0039: $41 == 470 
004D: jump_if_false @WHY4
0002: jump @FAIL4
:WHY4
0039: $41 == 477 
004D: jump_if_false @WHY5
0002: jump @FAIL5
:WHY5
0039: $41 == 489 
004D: jump_if_false @WHY6
0002: jump @FAIL6
:WHY6
0039: $41 == 498 
004D: jump_if_false @WHY7
0002: jump @FAIL7
:WHY7
0039: $41 == 514 
004D: jump_if_false @WHY8
0002: jump @FAIL8
:WHY8
0039: $41 == 521 
004D: jump_if_false @WHY9
0002: jump @FAIL9
:WHY9
0039: $41 == 526 
004D: jump_if_false @WHY10
0002: jump @FAIL10
:WHY10
0039: $41 == 549 
004D: jump_if_false @WHY11
0002: jump @FAIL11
:WHY11
0039: $41 == 554 
004D: jump_if_false @WHY12
0002: jump @FAIL12
:WHY12
0039: $41 == 578 
004D: jump_if_false @WHY13
0002: jump @FAIL13
:WHY13
0039: $41 == 594 
004D: jump_if_false @WHY14
0002: jump @FAIL14
:WHY14
0002: jump @TRST  

:HHHH
0004: $41 = 425 
0002: jump @TRST

:FAIL
0004: $41 = 447 
0002: jump @TRST

:FAIL2
0004: $41 = 460 
0002: jump @TRST

:FAIL3
0004: $41 = 469 
0002: jump @TRST 

:FAIL4
0004: $41 = 476 
0002: jump @TRST 

:FAIL5
0004: $41 = 487 
0002: jump @TRST

:FAIL6
0004: $41 = 497 
0002: jump @TRST

:FAIL7
0004: $41 = 511 
0002: jump @TRST    

:FAIL8
0004: $41 = 519 
0002: jump @TRST

:FAIL9
0004: $41 = 525 
0002: jump @TRST

:FAIL10
0004: $41 = 548 
0002: jump @TRST

:FAIL11
0004: $41 = 553 
0002: jump @TRST

:FAIL12
0004: $41 = 577 
0002: jump @TRST

:FAIL13
0004: $41 = 592 
0002: jump @TRST

:FAIL14
0004: $41 = 417 
0002: jump @TRST

:ENDE  
0001: wait 0
01C3: remove_references_to_car 5@ 
0002: jump @WACHT  __SBFTR 