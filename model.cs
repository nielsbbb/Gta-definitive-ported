   Z�
M �����
IM ���� ����  �	TEXT1 ��
?M ���� ���� ����  I	G��	   �
M ���� q����
M x��� ���� ����IG	��	 	 2�
M J��� ����
M 8��� �����
M &��� ���� `���I	G
��	 
 2�
M ���� q����
M ���� �����
M ���� ���� ���I
G��	  2�
M ���� ����
M ���� �����
M ���� {��� ����IG��	  2�
M T��� �����
M B��� �����
M 0��� )��� j���VAR    ONMISSION �  PLAYER_ACTOR    PLAYER_CHAR    PLAYER_GROUP    SECOND_PLAYER �   FLAG    SRC l	  {$CLEO .cs}
 
0000: NOP

:WACHT
0001: wait 90
0A90: is_hid_pressed 7
004D: jump_if_false @WACHT 
0A90: is_hid_pressed 73
004D: jump_if_false @WACHT
0002: jump @START

 :START

:ACTION0
0001: wait 0
03E5: show_text_box 'TEXT1'
0A90: is_hid_pressed 63
004D: jump_if_false @VOL1 
0002: jump @NEXT
:VOL1  
0002: jump @ACTION0

:NEXT
0001: wait 0
0249: release_model #BFORI
0247: load_model #male01
038B: load_requested_models
09C7: change_player $PLAYER_CHAR model_to #male01

:MENU
0001: wait 0
0A90: is_hid_pressed 12
004D: jump_if_false @ABC 
0002: jump @PED
:ABC
0A90: is_hid_pressed 16
004D: jump_if_false @ABB
0002: jump @WACHT
:ABB 
0002: jump @MENU
  
:PED 
0249: release_model #male01
0247: load_model #BFORI
038B: load_requested_models
09C7: change_player $PLAYER_CHAR model_to #BFORI

:MENU1
0001: wait 50
0A90: is_hid_pressed 12
004D: jump_if_false @SKIN1 
0002: jump @PED1
:SKIN1
0A90: is_hid_pressed 16
004D: jump_if_false @VOET1
0002: jump @WACHT
:VOET1
0A90: is_hid_pressed 13
004D: jump_if_false @MENS1
0002: jump @NEXT
:MENS1  
0002: jump @MENU1

:PED1 
0249: release_model #BFORI
0247: load_model #BFOST
038B: load_requested_models
09C7: change_player $PLAYER_CHAR model_to #BFOST

:MENU2
0001: wait 50
0A90: is_hid_pressed 13
004D: jump_if_false @SKIN2 
0002: jump @PED
:SKIN2
0A90: is_hid_pressed 16
004D: jump_if_false @VOET2
0002: jump @WACHT
:VOET2
0A90: is_hid_pressed 12
004D: jump_if_false @MENS2
0002: jump @PED2
:MENS2  
0002: jump @MENU2
 
:PED2 
0249: release_model #BFOST
0247: load_model #vbfycrp
038B: load_requested_models
09C7: change_player $PLAYER_CHAR model_to #vbfycrp

:MENU3
0001: wait 50
0A90: is_hid_pressed 13
004D: jump_if_false @SKIN3
0002: jump @PED1
:SKIN3
0A90: is_hid_pressed 16
004D: jump_if_false @VOET3
0002: jump @WACHT
:VOET3
0A90: is_hid_pressed 12
004D: jump_if_false @MENS3
0002: jump @PED3
:MENS3  
0002: jump @MENU3

:PED3
0249: release_model #vbfycrp
0247: load_model #bfyri
038B: load_requested_models
09C7: change_player $PLAYER_CHAR model_to #bfyri

:MENU4
0001: wait 50
0A90: is_hid_pressed 13
004D: jump_if_false @SKIN4
0002: jump @PED2
:SKIN4
0A90: is_hid_pressed 16
004D: jump_if_false @VOET4
0002: jump @WACHT
:VOET4
0A90: is_hid_pressed 12
004D: jump_if_false @MENS4
0002: jump @PED4
:MENS4
0002: jump @MENU4

:PED4�  __SBFTR 