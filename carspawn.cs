    А Zљ
M Ш   љ
M Ш    ┴   I I ├ д   ZG   ─       а@├шеЙ    ZH M ┴   Ц        т	TEXT1   љ
?M U    <   љ
M C        v     
  9  йM         Н     љ Н     ├  Ш   VAR    ONMISSION ў  PLAYER_ACTOR    PLAYER_CHAR    PLAYER_GROUP    SECOND_PLAYER џ   FLAG    SRC 3  {$CLEO .cs}
 
 0000: NOP
 0006: 23@ = 417

:WACHT
0001: wait 90
0A90: is_hid_pressed 15
004D: jump_if_false @WACHT 
0A90: is_hid_pressed 12
004D: jump_if_false @WACHT
0002: jump @START

:TRST
0249: release_model 5@
0249: release_model 23@ 
01C3: remove_references_to_car 5@
00A6: destroy_car 5@ 

:START
0001: wait 90 
0247: load_model 23@   
0001: wait 0  
04C4: store_coords_to 1@ 2@ 3@  from_actor $PLAYER_ACTOR with_offset 0.0 5.0 -0.33
:CAR
0001: wait 90
0248:   model 23@ available
004D: jump_if_false @START
00A5: 5@ = create_car 23@ at 1@ 2@ 3@

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
000A: 23@ += 1
0039: 23@ == 445 
004D: jump_if_false @WHY
0002: jump @HHHH
:WHY
0002: jump @TRST  

:HHHH
0004: 23@ = 400 
0002: jump @TRST 

:ENDE  
0001: wait 0
01C3: remove_references_to_car 5@ 
0002: jump @WACHT

  __SBFTR 