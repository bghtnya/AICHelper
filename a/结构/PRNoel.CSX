
<Structures>
  <Structure Name="PRNoel" AutoFill="0" AutoCreate="1" DefaultHex="0" AutoDestroy="0" DoNotSaveLocal="0" RLECompression="1" AutoCreateStructsize="4096">
    <Elements>
      <Element Offset="16" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000010" Description="m_CachedPtr" DisplayMethod="unsigned integer"/>
      <Element Offset="24" Vartype="Pointer" Bytesize="8" OffsetHex="00000018" Description="Mp" DisplayMethod="unsigned integer">
        <Structure Name="Map2d" AutoFill="0" AutoCreate="1" DefaultHex="0" AutoDestroy="0" DoNotSaveLocal="0" RLECompression="1" AutoCreateStructsize="4096">
          <Elements>
            <Element Offset="16" Vartype="Pointer" Bytesize="8" OffsetHex="00000010" Description="M2D" DisplayMethod="unsigned integer"/>
            <Element Offset="24" Vartype="Pointer" Bytesize="8" OffsetHex="00000018" ChildStruct="String" Description="key" DisplayMethod="unsigned integer"/>
            <Element Offset="32" Vartype="Pointer" Bytesize="8" OffsetHex="00000020" ChildStruct="String" Description="comment" DisplayMethod="unsigned integer"/>
            <Element Offset="40" Vartype="Pointer" Bytesize="8" OffsetHex="00000028" Description="Meta" DisplayMethod="unsigned integer"/>
            <Element Offset="48" Vartype="Pointer" Bytesize="8" OffsetHex="00000030" Description="Dgn" DisplayMethod="unsigned integer"/>
            <Element Offset="56" Vartype="Pointer" Bytesize="8" OffsetHex="00000038" Description="SubMapData" DisplayMethod="unsigned integer"/>
            <Element Offset="64" Vartype="Pointer" Bytesize="8" OffsetHex="00000040" Description="AAPt" DisplayMethod="unsigned integer"/>
            <Element Offset="72" Vartype="Pointer" Bytesize="8" OffsetHex="00000048" Description="AManpu" DisplayMethod="unsigned integer"/>
            <Element Offset="80" Vartype="Pointer" Bytesize="8" OffsetHex="00000050" Description="Aadditional_for_editor" DisplayMethod="unsigned integer"/>
            <Element Offset="88" Vartype="Pointer" Bytesize="8" OffsetHex="00000058" Description="ALay" DisplayMethod="unsigned integer"/>
            <Element Offset="96" Vartype="Pointer" Bytesize="8" OffsetHex="00000060" Description="CR" DisplayMethod="unsigned integer"/>
            <Element Offset="104" Vartype="Pointer" Bytesize="8" OffsetHex="00000068" Description="BaLoad" DisplayMethod="unsigned integer"/>
            <Element Offset="112" Vartype="Pointer" Bytesize="8" OffsetHex="00000070" Description="AMov" DisplayMethod="unsigned integer"/>
            <Element Offset="120" Vartype="Pointer" Bytesize="8" OffsetHex="00000078" Description="APhysics" DisplayMethod="unsigned integer"/>
            <Element Offset="128" Vartype="Pointer" Bytesize="8" OffsetHex="00000080" Description="AMovRemoveStack" DisplayMethod="unsigned integer"/>
            <Element Offset="136" Vartype="Pointer" Bytesize="8" OffsetHex="00000088" Description="OGob2Physics" DisplayMethod="unsigned integer"/>
            <Element Offset="144" Vartype="Pointer" Bytesize="8" OffsetHex="00000090" Description="ABcCon" DisplayMethod="unsigned integer"/>
            <Element Offset="152" Vartype="Pointer" Bytesize="8" OffsetHex="00000098" Description="MovP" DisplayMethod="unsigned integer"/>
            <Element Offset="160" Vartype="Pointer" Bytesize="8" OffsetHex="000000A0" Description="AMovP" DisplayMethod="unsigned integer"/>
            <Element Offset="168" Vartype="Pointer" Bytesize="8" OffsetHex="000000A8" Description="ASubMaps" DisplayMethod="unsigned integer"/>
            <Element Offset="176" Vartype="Pointer" Bytesize="8" OffsetHex="000000B0" Description="EVC" DisplayMethod="unsigned integer"/>
            <Element Offset="184" Vartype="Pointer" Bytesize="8" OffsetHex="000000B8" Description="ADrop" DisplayMethod="unsigned integer"/>
            <Element Offset="192" Vartype="Pointer" Bytesize="8" OffsetHex="000000C0" Description="AActivatable" DisplayMethod="unsigned integer"/>
            <Element Offset="200" Vartype="Pointer" Bytesize="8" OffsetHex="000000C8" Description="APxlAnim" DisplayMethod="unsigned integer"/>
            <Element Offset="208" Vartype="Pointer" Bytesize="8" OffsetHex="000000D0" Description="ALight" DisplayMethod="unsigned integer"/>
            <Element Offset="216" Vartype="Pointer" Bytesize="8" OffsetHex="000000D8" Description="KeyLayer" DisplayMethod="unsigned integer"/>
            <Element Offset="224" Vartype="Pointer" Bytesize="8" OffsetHex="000000E0" Description="ARunningObject" DisplayMethod="unsigned integer"/>
            <Element Offset="232" Vartype="Pointer" Bytesize="8" OffsetHex="000000E8" Description="AEvLoadOnce" DisplayMethod="unsigned integer"/>
            <Element Offset="240" Vartype="Pointer" Bytesize="8" OffsetHex="000000F0" Description="AEvStack" DisplayMethod="unsigned integer"/>
            <Element Offset="248" Vartype="Pointer" Bytesize="8" OffsetHex="000000F8" Description="OGob_tags" DisplayMethod="unsigned integer"/>
            <Element Offset="256" Vartype="Pointer" Bytesize="8" OffsetHex="00000100" Description="MyCollider" DisplayMethod="unsigned integer"/>
            <Element Offset="264" Vartype="Pointer" Bytesize="8" OffsetHex="00000108" Description="BCC" DisplayMethod="unsigned integer"/>
            <Element Offset="272" Vartype="Pointer" Bytesize="8" OffsetHex="00000110" Description="ATortureListener" DisplayMethod="unsigned integer"/>
            <Element Offset="280" Vartype="Pointer" Bytesize="8" OffsetHex="00000118" Description="ARedrawingChip" DisplayMethod="unsigned integer"/>
            <Element Offset="288" Vartype="Pointer" Bytesize="8" OffsetHex="00000120" Description="TalkTarget_" DisplayMethod="unsigned integer"/>
            <Element Offset="296" Vartype="Pointer" Bytesize="8" OffsetHex="00000128" Description="Gob" DisplayMethod="unsigned integer"/>
            <Element Offset="304" Vartype="Pointer" Bytesize="8" OffsetHex="00000130" Description="EF" DisplayMethod="unsigned integer"/>
            <Element Offset="312" Vartype="Pointer" Bytesize="8" OffsetHex="00000138" Description="EFT" DisplayMethod="unsigned integer"/>
            <Element Offset="320" Vartype="Pointer" Bytesize="8" OffsetHex="00000140" Description="EFC" DisplayMethod="unsigned integer"/>
            <Element Offset="328" Vartype="Pointer" Bytesize="8" OffsetHex="00000148" Description="EFD" DisplayMethod="unsigned integer"/>
            <Element Offset="336" Vartype="Pointer" Bytesize="8" OffsetHex="00000150" Description="EFDT" DisplayMethod="unsigned integer"/>
            <Element Offset="344" Vartype="Pointer" Bytesize="8" OffsetHex="00000158" Description="EFDC" DisplayMethod="unsigned integer"/>
            <Element Offset="352" Vartype="Pointer" Bytesize="8" OffsetHex="00000160" Description="DropCon" DisplayMethod="unsigned integer"/>
            <Element Offset="360" Vartype="Pointer" Bytesize="8" OffsetHex="00000168" Description="NM" DisplayMethod="unsigned integer"/>
            <Element Offset="368" Vartype="Pointer" Bytesize="8" OffsetHex="00000170" Description="DmgCntCon" DisplayMethod="unsigned integer"/>
            <Element Offset="376" Vartype="Pointer" Bytesize="8" OffsetHex="00000178" Description="BlurDraw" DisplayMethod="unsigned integer"/>
            <Element Offset="384" Vartype="Pointer" Bytesize="8" OffsetHex="00000180" Description="EditorTransform" DisplayMethod="unsigned integer"/>
            <Element Offset="392" Vartype="Pointer" Bytesize="8" OffsetHex="00000188" Description="MMRD" DisplayMethod="unsigned integer"/>
            <Element Offset="400" Vartype="Pointer" Bytesize="8" OffsetHex="00000190" Description="MyDrawerUCol" DisplayMethod="unsigned integer"/>
            <Element Offset="408" Vartype="Pointer" Bytesize="8" OffsetHex="00000198" Description="MyDrawerB" DisplayMethod="unsigned integer"/>
            <Element Offset="416" Vartype="Pointer" Bytesize="8" OffsetHex="000001A0" Description="MyDrawerG" DisplayMethod="unsigned integer"/>
            <Element Offset="424" Vartype="Pointer" Bytesize="8" OffsetHex="000001A8" Description="MyDrawerT" DisplayMethod="unsigned integer"/>
            <Element Offset="432" Vartype="Pointer" Bytesize="8" OffsetHex="000001B0" Description="MyDrawerTT" DisplayMethod="unsigned integer"/>
            <Element Offset="440" Vartype="Pointer" Bytesize="8" OffsetHex="000001B8" Description="MyDrawerL" DisplayMethod="unsigned integer"/>
            <Element Offset="448" Vartype="Pointer" Bytesize="8" OffsetHex="000001C0" Description="MyDrawerUGrd" DisplayMethod="unsigned integer"/>
            <Element Offset="456" Vartype="Pointer" Bytesize="8" OffsetHex="000001C8" Description="MyDrawerBGrd" DisplayMethod="unsigned integer"/>
            <Element Offset="464" Vartype="Pointer" Bytesize="8" OffsetHex="000001D0" Description="MyDrawerGGrd" DisplayMethod="unsigned integer"/>
            <Element Offset="472" Vartype="Pointer" Bytesize="8" OffsetHex="000001D8" Description="MyDrawerTGrd" DisplayMethod="unsigned integer"/>
            <Element Offset="480" Vartype="Pointer" Bytesize="8" OffsetHex="000001E0" Description="MyDrawerWater" DisplayMethod="unsigned integer"/>
            <Element Offset="488" Vartype="Pointer" Bytesize="8" OffsetHex="000001E8" Description="Unstb" DisplayMethod="unsigned integer"/>
            <Element Offset="496" Vartype="Float" Bytesize="4" OffsetHex="000001F0" Description="CLEN" DisplayMethod="unsigned integer"/>
            <Element Offset="500" Vartype="Float" Bytesize="4" OffsetHex="000001F4" Description="rCLEN" DisplayMethod="unsigned integer"/>
            <Element Offset="504" Vartype="Float" Bytesize="4" OffsetHex="000001F8" Description="mover_scale" DisplayMethod="unsigned integer"/>
            <Element Offset="508" Vartype="Byte" Bytesize="1" OffsetHex="000001FC" Description="handle" DisplayMethod="unsigned integer"/>
            <Element Offset="512" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000200" Description="mode" DisplayMethod="unsigned integer"/>
            <Element Offset="516" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000204" Description="width" DisplayMethod="unsigned integer"/>
            <Element Offset="520" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000208" Description="height" DisplayMethod="unsigned integer"/>
            <Element Offset="524" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000020C" Description="clms" DisplayMethod="unsigned integer"/>
            <Element Offset="528" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000210" Description="rows" DisplayMethod="unsigned integer"/>
            <Element Offset="532" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000214" Description="crop_" DisplayMethod="unsigned integer"/>
            <Element Offset="536" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000218" Description="bgcol" DisplayMethod="unsigned integer"/>
            <Element Offset="540" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000021C" Description="bgcol0" DisplayMethod="unsigned integer"/>
            <Element Offset="544" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000220" Description="maxChipIndex" DisplayMethod="unsigned integer"/>
            <Element Offset="548" Vartype="Byte" Bytesize="1" OffsetHex="00000224" Description="make_draw_arranger" DisplayMethod="unsigned integer"/>
            <Element Offset="549" Vartype="Byte" Bytesize="1" OffsetHex="00000225" Description="need_reentry_flag_" DisplayMethod="unsigned integer"/>
            <Element Offset="550" Vartype="Byte" Bytesize="1" OffsetHex="00000226" Description="need_reentry_gradation_flag_" DisplayMethod="unsigned integer"/>
            <Element Offset="551" Vartype="Byte" Bytesize="1" OffsetHex="00000227" Description="need_update_collider" DisplayMethod="unsigned integer"/>
            <Element Offset="552" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000228" Description="update_mesh_flag_" DisplayMethod="unsigned integer"/>
            <Element Offset="556" Vartype="Byte" Bytesize="1" OffsetHex="0000022C" Description="loadOnlyBasicFlag" DisplayMethod="unsigned integer"/>
            <Element Offset="557" Vartype="Byte" Bytesize="1" OffsetHex="0000022D" Description="binary_version" DisplayMethod="unsigned integer"/>
            <Element Offset="560" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000230" Description="binary_content_position" DisplayMethod="unsigned integer"/>
            <Element Offset="564" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000234" Description="t_load_cover" DisplayMethod="unsigned integer"/>
            <Element Offset="568" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000238" Description="load_cover_col" DisplayMethod="unsigned integer"/>
            <Element Offset="572" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000023C" Description="mover_count" DisplayMethod="unsigned integer"/>
            <Element Offset="576" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000240" Description="pxlanim_count" DisplayMethod="unsigned integer"/>
            <Element Offset="580" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000244" Description="cmd_reload_flg" DisplayMethod="unsigned integer"/>
            <Element Offset="584" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000248" Description="light_cnt" DisplayMethod="unsigned integer"/>
            <Element Offset="588" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000024C" Description="cmd_loadevent_execute" DisplayMethod="unsigned integer"/>
            <Element Offset="592" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000250" Description="camx" DisplayMethod="unsigned integer"/>
            <Element Offset="596" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000254" Description="camy" DisplayMethod="unsigned integer"/>
            <Element Offset="600" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000258" Description="camw" DisplayMethod="unsigned integer"/>
            <Element Offset="604" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000025C" Description="camh" DisplayMethod="unsigned integer"/>
            <Element Offset="608" Vartype="Float" Bytesize="4" OffsetHex="00000260" Description="floort" DisplayMethod="unsigned integer"/>
            <Element Offset="612" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000264" Description="check_icon_shift" DisplayMethod="unsigned integer"/>
            <Element Offset="616" Vartype="Byte" Bytesize="1" OffsetHex="00000268" Description="stack_to_map" DisplayMethod="unsigned integer"/>
            <Element Offset="620" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000026C" Description="mover_running_i" DisplayMethod="unsigned integer"/>
            <Element Offset="624" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000270" Description="redrawing_chip_count" DisplayMethod="unsigned integer"/>
          </Elements>
        </Structure>
      </Element>
      <Element Offset="32" Vartype="Pointer" Bytesize="8" OffsetHex="00000020" ChildStruct="String" Description="key_" DisplayMethod="unsigned integer"/>
      <Element Offset="40" Vartype="Pointer" Bytesize="8" OffsetHex="00000028" Description="ACarry" DisplayMethod="unsigned integer"/>
      <Element Offset="48" Vartype="Pointer" Bytesize="8" OffsetHex="00000030" Description="Phy" DisplayMethod="unsigned integer"/>
      <Element Offset="56" Vartype="Pointer" Bytesize="8" OffsetHex="00000038" Description="FootD" DisplayMethod="unsigned integer"/>
      <Element Offset="64" Vartype="Pointer" Bytesize="8" OffsetHex="00000040" Description="CC" DisplayMethod="unsigned integer"/>
      <Element Offset="72" Vartype="Pointer" Bytesize="8" OffsetHex="00000048" Description="NCM" DisplayMethod="unsigned integer"/>
      <Element Offset="80" Vartype="Pointer" Bytesize="8" OffsetHex="00000050" Description="MScr" DisplayMethod="unsigned integer"/>
      <Element Offset="88" Vartype="Pointer" Bytesize="8" OffsetHex="00000058" ChildStruct="String" Description="snd_key_" DisplayMethod="unsigned integer"/>
      <Element Offset="96" Vartype="Float" Bytesize="4" OffsetHex="00000060" Description="sizex" DisplayMethod="unsigned integer"/>
      <Element Offset="100" Vartype="Float" Bytesize="4" OffsetHex="00000064" Description="sizey" DisplayMethod="unsigned integer"/>
      <Element Offset="104" Vartype="Byte" Bytesize="1" OffsetHex="00000068" Description="divide_clen_size" DisplayMethod="unsigned integer"/>
      <Element Offset="108" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000006C" Description="aim" DisplayMethod="unsigned integer"/>
      <Element Offset="112" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000070" Description="gravity_aim" DisplayMethod="unsigned integer"/>
      <Element Offset="116" Vartype="Byte" Bytesize="1" OffsetHex="00000074" Description="floating" DisplayMethod="unsigned integer"/>
      <Element Offset="120" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000078" Description="walk_auto_assisting" DisplayMethod="unsigned integer"/>
      <Element Offset="124" Vartype="Byte" Bytesize="1" OffsetHex="0000007C" Description="slip_slope" DisplayMethod="unsigned integer"/>
      <Element Offset="128" Vartype="Float" Bytesize="4" OffsetHex="00000080" Description="x_" DisplayMethod="unsigned integer"/>
      <Element Offset="132" Vartype="Float" Bytesize="4" OffsetHex="00000084" Description="y_" DisplayMethod="unsigned integer"/>
      <Element Offset="136" Vartype="Float" Bytesize="4" OffsetHex="00000088" Description="vx_" DisplayMethod="unsigned integer"/>
      <Element Offset="140" Vartype="Float" Bytesize="4" OffsetHex="0000008C" Description="vy_" DisplayMethod="unsigned integer"/>
      <Element Offset="144" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000090" Description="index" DisplayMethod="unsigned integer"/>
      <Element Offset="148" Vartype="Float" Bytesize="4" OffsetHex="00000094" Description="drawx_" DisplayMethod="unsigned integer"/>
      <Element Offset="152" Vartype="Float" Bytesize="4" OffsetHex="00000098" Description="drawy_" DisplayMethod="unsigned integer"/>
      <Element Offset="156" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000009C" Description="draw_assist" DisplayMethod="unsigned integer"/>
      <Element Offset="160" Vartype="4 Bytes" Bytesize="4" OffsetHex="000000A0" Description="hit_wall_" DisplayMethod="unsigned integer"/>
      <Element Offset="164" Vartype="Float" Bytesize="4" OffsetHex="000000A4" Description="base_gravity_" DisplayMethod="unsigned integer"/>
      <Element Offset="168" Vartype="Byte" Bytesize="1" OffsetHex="000000A8" Description="ringoutable" DisplayMethod="unsigned integer"/>
      <Element Offset="169" Vartype="Byte" Bytesize="1" OffsetHex="000000A9" Description="do_not_destruct_when_remove" DisplayMethod="unsigned integer"/>
      <Element Offset="170" Vartype="Byte" Bytesize="1" OffsetHex="000000AA" Description="move_script_attached" DisplayMethod="unsigned integer"/>
      <Element Offset="171" Vartype="Byte" Bytesize="1" OffsetHex="000000AB" Description="fix_aim_" DisplayMethod="unsigned integer"/>
      <Element Offset="172" Vartype="Byte" Bytesize="1" OffsetHex="000000AC" Description="fix_transform_position_flag" DisplayMethod="unsigned integer"/>
      <Element Offset="176" Vartype="Pointer" Bytesize="8" OffsetHex="000000B0" Description="NoDamage" DisplayMethod="unsigned integer">
        <Structure Name="M2NoDamageManager" AutoFill="0" AutoCreate="1" DefaultHex="0" AutoDestroy="0" DoNotSaveLocal="0" RLECompression="1" AutoCreateStructsize="4096">
          <Elements>
            <Element Offset="16" Vartype="Pointer" Bytesize="8" OffsetHex="00000010" Description="Mp" DisplayMethod="unsigned integer">
              <Structure Name="自动创建 从 29A7C110A80" AutoFill="0" AutoCreate="1" DefaultHex="0" AutoDestroy="0" DoNotSaveLocal="0" RLECompression="1" AutoCreateStructsize="4096">
                <Elements>
                  <Element Offset="16" Vartype="Pointer" Bytesize="8" OffsetHex="00000010" Description="M2D" DisplayMethod="unsigned integer"/>
                  <Element Offset="24" Vartype="Pointer" Bytesize="8" OffsetHex="00000018" ChildStruct="String" Description="key" DisplayMethod="unsigned integer"/>
                  <Element Offset="32" Vartype="Pointer" Bytesize="8" OffsetHex="00000020" ChildStruct="String" Description="comment" DisplayMethod="unsigned integer"/>
                  <Element Offset="40" Vartype="Pointer" Bytesize="8" OffsetHex="00000028" Description="Meta" DisplayMethod="unsigned integer"/>
                  <Element Offset="48" Vartype="Pointer" Bytesize="8" OffsetHex="00000030" Description="Dgn" DisplayMethod="unsigned integer"/>
                  <Element Offset="56" Vartype="Pointer" Bytesize="8" OffsetHex="00000038" Description="SubMapData" DisplayMethod="unsigned integer"/>
                  <Element Offset="64" Vartype="Pointer" Bytesize="8" OffsetHex="00000040" Description="AAPt" DisplayMethod="unsigned integer"/>
                  <Element Offset="72" Vartype="Pointer" Bytesize="8" OffsetHex="00000048" Description="AManpu" DisplayMethod="unsigned integer"/>
                  <Element Offset="80" Vartype="Pointer" Bytesize="8" OffsetHex="00000050" Description="Aadditional_for_editor" DisplayMethod="unsigned integer"/>
                  <Element Offset="88" Vartype="Pointer" Bytesize="8" OffsetHex="00000058" Description="ALay" DisplayMethod="unsigned integer"/>
                  <Element Offset="96" Vartype="Pointer" Bytesize="8" OffsetHex="00000060" Description="CR" DisplayMethod="unsigned integer"/>
                  <Element Offset="104" Vartype="Pointer" Bytesize="8" OffsetHex="00000068" Description="BaLoad" DisplayMethod="unsigned integer"/>
                  <Element Offset="112" Vartype="Pointer" Bytesize="8" OffsetHex="00000070" Description="AMov" DisplayMethod="unsigned integer"/>
                  <Element Offset="120" Vartype="Pointer" Bytesize="8" OffsetHex="00000078" Description="APhysics" DisplayMethod="unsigned integer"/>
                  <Element Offset="128" Vartype="Pointer" Bytesize="8" OffsetHex="00000080" Description="AMovRemoveStack" DisplayMethod="unsigned integer"/>
                  <Element Offset="136" Vartype="Pointer" Bytesize="8" OffsetHex="00000088" Description="OGob2Physics" DisplayMethod="unsigned integer"/>
                  <Element Offset="144" Vartype="Pointer" Bytesize="8" OffsetHex="00000090" Description="ABcCon" DisplayMethod="unsigned integer"/>
                  <Element Offset="152" Vartype="Pointer" Bytesize="8" OffsetHex="00000098" Description="MovP" DisplayMethod="unsigned integer"/>
                  <Element Offset="160" Vartype="Pointer" Bytesize="8" OffsetHex="000000A0" Description="AMovP" DisplayMethod="unsigned integer"/>
                  <Element Offset="168" Vartype="Pointer" Bytesize="8" OffsetHex="000000A8" Description="ASubMaps" DisplayMethod="unsigned integer"/>
                  <Element Offset="176" Vartype="Pointer" Bytesize="8" OffsetHex="000000B0" Description="EVC" DisplayMethod="unsigned integer"/>
                  <Element Offset="184" Vartype="Pointer" Bytesize="8" OffsetHex="000000B8" Description="ADrop" DisplayMethod="unsigned integer"/>
                  <Element Offset="192" Vartype="Pointer" Bytesize="8" OffsetHex="000000C0" Description="AActivatable" DisplayMethod="unsigned integer"/>
                  <Element Offset="200" Vartype="Pointer" Bytesize="8" OffsetHex="000000C8" Description="APxlAnim" DisplayMethod="unsigned integer"/>
                  <Element Offset="208" Vartype="Pointer" Bytesize="8" OffsetHex="000000D0" Description="ALight" DisplayMethod="unsigned integer"/>
                  <Element Offset="216" Vartype="Pointer" Bytesize="8" OffsetHex="000000D8" Description="KeyLayer" DisplayMethod="unsigned integer"/>
                  <Element Offset="224" Vartype="Pointer" Bytesize="8" OffsetHex="000000E0" Description="ARunningObject" DisplayMethod="unsigned integer"/>
                  <Element Offset="232" Vartype="Pointer" Bytesize="8" OffsetHex="000000E8" Description="AEvLoadOnce" DisplayMethod="unsigned integer"/>
                  <Element Offset="240" Vartype="Pointer" Bytesize="8" OffsetHex="000000F0" Description="AEvStack" DisplayMethod="unsigned integer"/>
                  <Element Offset="248" Vartype="Pointer" Bytesize="8" OffsetHex="000000F8" Description="OGob_tags" DisplayMethod="unsigned integer"/>
                  <Element Offset="256" Vartype="Pointer" Bytesize="8" OffsetHex="00000100" Description="MyCollider" DisplayMethod="unsigned integer"/>
                  <Element Offset="264" Vartype="Pointer" Bytesize="8" OffsetHex="00000108" Description="BCC" DisplayMethod="unsigned integer"/>
                  <Element Offset="272" Vartype="Pointer" Bytesize="8" OffsetHex="00000110" Description="ATortureListener" DisplayMethod="unsigned integer"/>
                  <Element Offset="280" Vartype="Pointer" Bytesize="8" OffsetHex="00000118" Description="ARedrawingChip" DisplayMethod="unsigned integer"/>
                  <Element Offset="288" Vartype="Pointer" Bytesize="8" OffsetHex="00000120" Description="TalkTarget_" DisplayMethod="unsigned integer"/>
                  <Element Offset="296" Vartype="Pointer" Bytesize="8" OffsetHex="00000128" Description="Gob" DisplayMethod="unsigned integer"/>
                  <Element Offset="304" Vartype="Pointer" Bytesize="8" OffsetHex="00000130" Description="EF" DisplayMethod="unsigned integer"/>
                  <Element Offset="312" Vartype="Pointer" Bytesize="8" OffsetHex="00000138" Description="EFT" DisplayMethod="unsigned integer"/>
                  <Element Offset="320" Vartype="Pointer" Bytesize="8" OffsetHex="00000140" Description="EFC" DisplayMethod="unsigned integer"/>
                  <Element Offset="328" Vartype="Pointer" Bytesize="8" OffsetHex="00000148" Description="EFD" DisplayMethod="unsigned integer"/>
                  <Element Offset="336" Vartype="Pointer" Bytesize="8" OffsetHex="00000150" Description="EFDT" DisplayMethod="unsigned integer"/>
                  <Element Offset="344" Vartype="Pointer" Bytesize="8" OffsetHex="00000158" Description="EFDC" DisplayMethod="unsigned integer"/>
                  <Element Offset="352" Vartype="Pointer" Bytesize="8" OffsetHex="00000160" Description="DropCon" DisplayMethod="unsigned integer"/>
                  <Element Offset="360" Vartype="Pointer" Bytesize="8" OffsetHex="00000168" Description="NM" DisplayMethod="unsigned integer"/>
                  <Element Offset="368" Vartype="Pointer" Bytesize="8" OffsetHex="00000170" Description="DmgCntCon" DisplayMethod="unsigned integer"/>
                  <Element Offset="376" Vartype="Pointer" Bytesize="8" OffsetHex="00000178" Description="BlurDraw" DisplayMethod="unsigned integer"/>
                  <Element Offset="384" Vartype="Pointer" Bytesize="8" OffsetHex="00000180" Description="EditorTransform" DisplayMethod="unsigned integer"/>
                  <Element Offset="392" Vartype="Pointer" Bytesize="8" OffsetHex="00000188" Description="MMRD" DisplayMethod="unsigned integer"/>
                  <Element Offset="400" Vartype="Pointer" Bytesize="8" OffsetHex="00000190" Description="MyDrawerUCol" DisplayMethod="unsigned integer"/>
                  <Element Offset="408" Vartype="Pointer" Bytesize="8" OffsetHex="00000198" Description="MyDrawerB" DisplayMethod="unsigned integer"/>
                  <Element Offset="416" Vartype="Pointer" Bytesize="8" OffsetHex="000001A0" Description="MyDrawerG" DisplayMethod="unsigned integer"/>
                  <Element Offset="424" Vartype="Pointer" Bytesize="8" OffsetHex="000001A8" Description="MyDrawerT" DisplayMethod="unsigned integer"/>
                  <Element Offset="432" Vartype="Pointer" Bytesize="8" OffsetHex="000001B0" Description="MyDrawerTT" DisplayMethod="unsigned integer"/>
                  <Element Offset="440" Vartype="Pointer" Bytesize="8" OffsetHex="000001B8" Description="MyDrawerL" DisplayMethod="unsigned integer"/>
                  <Element Offset="448" Vartype="Pointer" Bytesize="8" OffsetHex="000001C0" Description="MyDrawerUGrd" DisplayMethod="unsigned integer"/>
                  <Element Offset="456" Vartype="Pointer" Bytesize="8" OffsetHex="000001C8" Description="MyDrawerBGrd" DisplayMethod="unsigned integer"/>
                  <Element Offset="464" Vartype="Pointer" Bytesize="8" OffsetHex="000001D0" Description="MyDrawerGGrd" DisplayMethod="unsigned integer"/>
                  <Element Offset="472" Vartype="Pointer" Bytesize="8" OffsetHex="000001D8" Description="MyDrawerTGrd" DisplayMethod="unsigned integer"/>
                  <Element Offset="480" Vartype="Pointer" Bytesize="8" OffsetHex="000001E0" Description="MyDrawerWater" DisplayMethod="unsigned integer"/>
                  <Element Offset="488" Vartype="Pointer" Bytesize="8" OffsetHex="000001E8" Description="Unstb" DisplayMethod="unsigned integer"/>
                  <Element Offset="496" Vartype="Float" Bytesize="4" OffsetHex="000001F0" Description="CLEN" DisplayMethod="unsigned integer"/>
                  <Element Offset="500" Vartype="Float" Bytesize="4" OffsetHex="000001F4" Description="rCLEN" DisplayMethod="unsigned integer"/>
                  <Element Offset="504" Vartype="Float" Bytesize="4" OffsetHex="000001F8" Description="mover_scale" DisplayMethod="unsigned integer"/>
                  <Element Offset="508" Vartype="Byte" Bytesize="1" OffsetHex="000001FC" Description="handle" DisplayMethod="unsigned integer"/>
                  <Element Offset="512" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000200" Description="mode" DisplayMethod="unsigned integer"/>
                  <Element Offset="516" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000204" Description="width" DisplayMethod="unsigned integer"/>
                  <Element Offset="520" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000208" Description="height" DisplayMethod="unsigned integer"/>
                  <Element Offset="524" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000020C" Description="clms" DisplayMethod="unsigned integer"/>
                  <Element Offset="528" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000210" Description="rows" DisplayMethod="unsigned integer"/>
                  <Element Offset="532" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000214" Description="crop_" DisplayMethod="unsigned integer"/>
                  <Element Offset="536" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000218" Description="bgcol" DisplayMethod="unsigned integer"/>
                  <Element Offset="540" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000021C" Description="bgcol0" DisplayMethod="unsigned integer"/>
                  <Element Offset="544" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000220" Description="maxChipIndex" DisplayMethod="unsigned integer"/>
                  <Element Offset="548" Vartype="Byte" Bytesize="1" OffsetHex="00000224" Description="make_draw_arranger" DisplayMethod="unsigned integer"/>
                  <Element Offset="549" Vartype="Byte" Bytesize="1" OffsetHex="00000225" Description="need_reentry_flag_" DisplayMethod="unsigned integer"/>
                  <Element Offset="550" Vartype="Byte" Bytesize="1" OffsetHex="00000226" Description="need_reentry_gradation_flag_" DisplayMethod="unsigned integer"/>
                  <Element Offset="551" Vartype="Byte" Bytesize="1" OffsetHex="00000227" Description="need_update_collider" DisplayMethod="unsigned integer"/>
                  <Element Offset="552" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000228" Description="update_mesh_flag_" DisplayMethod="unsigned integer"/>
                  <Element Offset="556" Vartype="Byte" Bytesize="1" OffsetHex="0000022C" Description="loadOnlyBasicFlag" DisplayMethod="unsigned integer"/>
                  <Element Offset="557" Vartype="Byte" Bytesize="1" OffsetHex="0000022D" Description="binary_version" DisplayMethod="unsigned integer"/>
                  <Element Offset="560" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000230" Description="binary_content_position" DisplayMethod="unsigned integer"/>
                  <Element Offset="564" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000234" Description="t_load_cover" DisplayMethod="unsigned integer"/>
                  <Element Offset="568" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000238" Description="load_cover_col" DisplayMethod="unsigned integer"/>
                  <Element Offset="572" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000023C" Description="mover_count" DisplayMethod="unsigned integer"/>
                  <Element Offset="576" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000240" Description="pxlanim_count" DisplayMethod="unsigned integer"/>
                  <Element Offset="580" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000244" Description="cmd_reload_flg" DisplayMethod="unsigned integer"/>
                  <Element Offset="584" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000248" Description="light_cnt" DisplayMethod="unsigned integer"/>
                  <Element Offset="588" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000024C" Description="cmd_loadevent_execute" DisplayMethod="unsigned integer"/>
                  <Element Offset="592" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000250" Description="camx" DisplayMethod="unsigned integer"/>
                  <Element Offset="596" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000254" Description="camy" DisplayMethod="unsigned integer"/>
                  <Element Offset="600" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000258" Description="camw" DisplayMethod="unsigned integer"/>
                  <Element Offset="604" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000025C" Description="camh" DisplayMethod="unsigned integer"/>
                  <Element Offset="608" Vartype="Float" Bytesize="4" OffsetHex="00000260" Description="floort" DisplayMethod="unsigned integer"/>
                  <Element Offset="612" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000264" Description="check_icon_shift" DisplayMethod="unsigned integer"/>
                  <Element Offset="616" Vartype="Byte" Bytesize="1" OffsetHex="00000268" Description="stack_to_map" DisplayMethod="unsigned integer"/>
                  <Element Offset="620" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000026C" Description="mover_running_i" DisplayMethod="unsigned integer"/>
                  <Element Offset="624" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000270" Description="redrawing_chip_count" DisplayMethod="unsigned integer"/>
                </Elements>
              </Structure>
            </Element>
            <Element Offset="24" Vartype="Pointer" Bytesize="8" OffsetHex="00000018" Description="Ond" DisplayMethod="unsigned integer">
              <Structure Name="BDic`2" AutoFill="0" AutoCreate="1" DefaultHex="0" AutoDestroy="0" DoNotSaveLocal="0" RLECompression="1" AutoCreateStructsize="4096">
                <Elements>
                  <Element Offset="16" Vartype="Pointer" Bytesize="8" OffsetHex="00000010" Description="buckets" DisplayMethod="unsigned integer"/>
                  <Element Offset="24" Vartype="Pointer" Bytesize="8" OffsetHex="00000018" Description="entries" DisplayMethod="unsigned integer"/>
                  <Element Offset="32" Vartype="Pointer" Bytesize="8" OffsetHex="00000020" Description="comparer" DisplayMethod="unsigned integer"/>
                  <Element Offset="40" Vartype="Pointer" Bytesize="8" OffsetHex="00000028" Description="keys" DisplayMethod="unsigned integer"/>
                  <Element Offset="48" Vartype="Pointer" Bytesize="8" OffsetHex="00000030" Description="values" DisplayMethod="unsigned integer"/>
                  <Element Offset="56" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000038" Description="_syncRoot" DisplayMethod="unsigned integer"/>
                  <Element Offset="64" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000040" Description="count" DisplayMethod="unsigned integer"/>
                  <Element Offset="68" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000044" Description="version" DisplayMethod="unsigned integer"/>
                  <Element Offset="72" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000048" Description="freeList" DisplayMethod="unsigned integer"/>
                  <Element Offset="76" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000004C" Description="freeCount" DisplayMethod="unsigned integer"/>
                </Elements>
              </Structure>
            </Element>
            <Element Offset="32" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000020" Description="active_bits" DisplayMethod="unsigned integer"/>
          </Elements>
        </Structure>
      </Element>
      <Element Offset="184" Vartype="Pointer" Bytesize="8" OffsetHex="000000B8" Description="TeCon" DisplayMethod="unsigned integer"/>
      <Element Offset="192" Vartype="Pointer" Bytesize="8" OffsetHex="000000C0" Description="PtcHld" DisplayMethod="unsigned integer"/>
      <Element Offset="200" Vartype="Pointer" Bytesize="8" OffsetHex="000000C8" Description="PressCheck" DisplayMethod="unsigned integer"/>
      <Element Offset="208" Vartype="4 Bytes" Bytesize="4" OffsetHex="000000D0" Description="hp" DisplayMethod="unsigned integer"/>
      <Element Offset="212" Vartype="4 Bytes" Bytesize="4" OffsetHex="000000D4" Description="maxhp" DisplayMethod="unsigned integer"/>
      <Element Offset="216" Vartype="4 Bytes" Bytesize="4" OffsetHex="000000D8" Description="mp" DisplayMethod="unsigned integer"/>
      <Element Offset="220" Vartype="4 Bytes" Bytesize="4" OffsetHex="000000DC" Description="maxmp" DisplayMethod="unsigned integer"/>
      <Element Offset="224" Vartype="4 Bytes" Bytesize="4" OffsetHex="000000E0" Description="knockback_time" DisplayMethod="unsigned integer"/>
      <Element Offset="228" Vartype="Byte" Bytesize="1" OffsetHex="000000E4" Description="overkill" DisplayMethod="unsigned integer"/>
      <Element Offset="232" Vartype="Pointer" Bytesize="8" OffsetHex="000000E8" Description="AATalkable" DisplayMethod="unsigned integer"/>
      <Element Offset="240" Vartype="Pointer" Bytesize="8" OffsetHex="000000F0" Description="AAEvStand" DisplayMethod="unsigned integer"/>
      <Element Offset="248" Vartype="Pointer" Bytesize="8" OffsetHex="000000F8" Description="FindBccLadderClimbOut" DisplayMethod="unsigned integer"/>
      <Element Offset="256" Vartype="Float" Bytesize="4" OffsetHex="00000100" Description="walkSpeed" DisplayMethod="unsigned integer"/>
      <Element Offset="260" Vartype="Float" Bytesize="4" OffsetHex="00000104" Description="runSpeed" DisplayMethod="unsigned integer"/>
      <Element Offset="264" Vartype="Float" Bytesize="4" OffsetHex="00000108" Description="ySpeedMax0" DisplayMethod="unsigned integer"/>
      <Element Offset="268" Vartype="Float" Bytesize="4" OffsetHex="0000010C" Description="ySpeedStart" DisplayMethod="unsigned integer"/>
      <Element Offset="272" Vartype="Float" Bytesize="4" OffsetHex="00000110" Description="ySpeedStart_water" DisplayMethod="unsigned integer"/>
      <Element Offset="276" Vartype="Float" Bytesize="4" OffsetHex="00000114" Description="ySpeedKeyReleased_water" DisplayMethod="unsigned integer"/>
      <Element Offset="280" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000118" Description="JUMP_HOLD_MAXT_WATER" DisplayMethod="unsigned integer"/>
      <Element Offset="284" Vartype="Float" Bytesize="4" OffsetHex="0000011C" Description="accel_run_break" DisplayMethod="unsigned integer"/>
      <Element Offset="288" Vartype="Float" Bytesize="4" OffsetHex="00000120" Description="accel_run_break_air" DisplayMethod="unsigned integer"/>
      <Element Offset="292" Vartype="Byte" Bytesize="1" OffsetHex="00000124" Description="ladder_check" DisplayMethod="unsigned integer"/>
      <Element Offset="293" Vartype="Byte" Bytesize="1" OffsetHex="00000125" Description="jump_hold_lock_" DisplayMethod="unsigned integer"/>
      <Element Offset="296" Vartype="Float" Bytesize="4" OffsetHex="00000128" Description="jump_pushing" DisplayMethod="unsigned integer"/>
      <Element Offset="300" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000012C" Description="enemy_targetted" DisplayMethod="unsigned integer"/>
      <Element Offset="304" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000130" Description="simulate_key" DisplayMethod="unsigned integer"/>
      <Element Offset="308" Vartype="Byte" Bytesize="1" OffsetHex="00000134" Description="pre_ladder_shifting" DisplayMethod="unsigned integer"/>
      <Element Offset="309" Vartype="Byte" Bytesize="1" OffsetHex="00000135" Description="pee_lock" DisplayMethod="unsigned integer"/>
      <Element Offset="312" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000138" Description="ep" DisplayMethod="unsigned integer"/>
      <Element Offset="316" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000013C" Description="water_drunk" DisplayMethod="unsigned integer"/>
      <Element Offset="320" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000140" Description="juice_stock" DisplayMethod="unsigned integer"/>
      <Element Offset="324" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000144" Description="manip" DisplayMethod="unsigned integer"/>
      <Element Offset="328" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000148" Description="move_key" DisplayMethod="unsigned integer"/>
      <Element Offset="332" Vartype="Float" Bytesize="4" OffsetHex="0000014C" Description="last_foot_bottom_y_" DisplayMethod="unsigned integer"/>
      <Element Offset="336" Vartype="Byte" Bytesize="1" OffsetHex="00000150" Description="need_check_foot_camera_scroll" DisplayMethod="unsigned integer"/>
      <Element Offset="340" Vartype="Float" Bytesize="4" OffsetHex="00000154" Description="pre_camera_y" DisplayMethod="unsigned integer"/>
      <Element Offset="344" Vartype="Float" Bytesize="4" OffsetHex="00000158" Description="offset_pixel_x" DisplayMethod="unsigned integer"/>
      <Element Offset="348" Vartype="Float" Bytesize="4" OffsetHex="0000015C" Description="offset_pixel_y" DisplayMethod="unsigned integer"/>
      <Element Offset="352" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000160" Description="size_y_default_pixel" DisplayMethod="unsigned integer"/>
      <Element Offset="356" Vartype="Byte" Bytesize="1" OffsetHex="00000164" Description="force_crouch_mem" DisplayMethod="unsigned integer"/>
      <Element Offset="357" Vartype="Byte" Bytesize="1" OffsetHex="00000165" Description="change_crouch" DisplayMethod="unsigned integer"/>
      <Element Offset="358" Vartype="Byte" Bytesize="1" OffsetHex="00000166" Description="outfit_cannot_run" DisplayMethod="unsigned integer"/>
      <Element Offset="359" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000167" Description="checkevent" DisplayMethod="unsigned integer"/>
      <Element Offset="360" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000168" Description="bounds_" DisplayMethod="unsigned integer"/>
      <Element Offset="364" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000016C" Description="run_delay" DisplayMethod="unsigned integer"/>
      <Element Offset="368" Vartype="Float" Bytesize="4" OffsetHex="00000170" Description="base_gravity0" DisplayMethod="unsigned integer"/>
      <Element Offset="372" Vartype="Float" Bytesize="4" OffsetHex="00000174" Description="crouching" DisplayMethod="unsigned integer"/>
      <Element Offset="376" Vartype="Float" Bytesize="4" OffsetHex="00000178" Description="running_" DisplayMethod="unsigned integer"/>
      <Element Offset="380" Vartype="Float" Bytesize="4" OffsetHex="0000017C" Description="run_continue_time_" DisplayMethod="unsigned integer"/>
      <Element Offset="384" Vartype="Byte" Bytesize="1" OffsetHex="00000180" Description="target_calced" DisplayMethod="unsigned integer"/>
      <Element Offset="392" Vartype="Pointer" Bytesize="8" OffsetHex="00000188" Description="NM2D" DisplayMethod="unsigned integer"/>
      <Element Offset="400" Vartype="Pointer" Bytesize="8" OffsetHex="00000190" Description="Anm" DisplayMethod="unsigned integer"/>
      <Element Offset="408" Vartype="Pointer" Bytesize="8" OffsetHex="00000198" Description="RCenemy_sink" DisplayMethod="unsigned integer"/>
      <Element Offset="416" Vartype="Pointer" Bytesize="8" OffsetHex="000001A0" ChildStruct="String" Description="fix_pose" DisplayMethod="unsigned integer"/>
      <Element Offset="424" Vartype="Pointer" Bytesize="8" OffsetHex="000001A8" Description="Ser" DisplayMethod="unsigned integer"/>
      <Element Offset="432" Vartype="Pointer" Bytesize="8" OffsetHex="000001B0" Description="GageBrk" DisplayMethod="unsigned integer"/>
      <Element Offset="440" Vartype="Pointer" Bytesize="8" OffsetHex="000001B8" Description="EggCon" DisplayMethod="unsigned integer"/>
      <Element Offset="448" Vartype="Pointer" Bytesize="8" OffsetHex="000001C0" Description="EpCon" DisplayMethod="unsigned integer"/>
      <Element Offset="456" Vartype="Pointer" Bytesize="8" OffsetHex="000001C8" Description="BetoMng" DisplayMethod="unsigned integer"/>
      <Element Offset="464" Vartype="Pointer" Bytesize="8" OffsetHex="000001D0" Description="Skill" DisplayMethod="unsigned integer"/>
      <Element Offset="472" Vartype="Pointer" Bytesize="8" OffsetHex="000001D8" Description="AbsorbCon" DisplayMethod="unsigned integer"/>
      <Element Offset="480" Vartype="Pointer" Bytesize="8" OffsetHex="000001E0" Description="VO" DisplayMethod="unsigned integer"/>
      <Element Offset="488" Vartype="Pointer" Bytesize="8" OffsetHex="000001E8" Description="TeFallShift" DisplayMethod="unsigned integer"/>
      <Element Offset="496" Vartype="Pointer" Bytesize="8" OffsetHex="000001F0" Description="IMNG" DisplayMethod="unsigned integer"/>
      <Element Offset="504" Vartype="Pointer" Bytesize="8" OffsetHex="000001F8" Description="MistApply" DisplayMethod="unsigned integer"/>
      <Element Offset="512" Vartype="Pointer" Bytesize="8" OffsetHex="00000200" Description="Onnie" DisplayMethod="unsigned integer"/>
      <Element Offset="520" Vartype="Pointer" Bytesize="8" OffsetHex="00000208" Description="Ydrg" DisplayMethod="unsigned integer"/>
      <Element Offset="528" Vartype="Pointer" Bytesize="8" OffsetHex="00000210" Description="UP" DisplayMethod="unsigned integer"/>
      <Element Offset="536" Vartype="Pointer" Bytesize="8" OffsetHex="00000218" Description="FD_ignoreHitToBlockCollider" DisplayMethod="unsigned integer"/>
      <Element Offset="544" Vartype="Pointer" Bytesize="8" OffsetHex="00000220" ChildStruct="String" Description="_temp_puzzle_cache_str" DisplayMethod="unsigned integer"/>
      <Element Offset="552" Vartype="Pointer" Bytesize="8" OffsetHex="00000228" Description="FD_drawWaterRelease" DisplayMethod="unsigned integer"/>
      <Element Offset="560" Vartype="Float" Bytesize="4" OffsetHex="00000230" Description="_base_TS" DisplayMethod="unsigned integer"/>
      <Element Offset="564" Vartype="Float" Bytesize="4" OffsetHex="00000234" Description="weight0" DisplayMethod="unsigned integer"/>
      <Element Offset="568" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000238" Description="outfit_default_mnp" DisplayMethod="unsigned integer"/>
      <Element Offset="572" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000023C" Description="outfit_default_dcl" DisplayMethod="unsigned integer"/>
      <Element Offset="576" Vartype="Float" Bytesize="4" OffsetHex="00000240" Description="absorb_pose_change_ratio" DisplayMethod="unsigned integer"/>
      <Element Offset="580" Vartype="Byte" Bytesize="1" OffsetHex="00000244" Description="need_check_bounds" DisplayMethod="unsigned integer"/>
      <Element Offset="584" Vartype="Float" Bytesize="4" OffsetHex="00000248" Description="wind_apply_t" DisplayMethod="unsigned integer"/>
      <Element Offset="588" Vartype="Float" Bytesize="4" OffsetHex="0000024C" Description="absorb_additional_dying" DisplayMethod="unsigned integer"/>
      <Element Offset="592" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000250" Description="BufTg" DisplayMethod="unsigned integer"/>
      <Element Offset="600" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000258" Description="state" DisplayMethod="unsigned integer"/>
      <Element Offset="604" Vartype="4 Bytes" Bytesize="4" OffsetHex="0000025C" Description="decline" DisplayMethod="unsigned integer"/>
      <Element Offset="608" Vartype="Float" Bytesize="4" OffsetHex="00000260" Description="t_state" DisplayMethod="unsigned integer"/>
      <Element Offset="612" Vartype="Float" Bytesize="4" OffsetHex="00000264" Description="check_lava" DisplayMethod="unsigned integer"/>
      <Element Offset="616" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000268" Description="lava_burn_dount" DisplayMethod="unsigned integer"/>
      <Element Offset="620" Vartype="Float" Bytesize="4" OffsetHex="0000026C" Description="frozen_fineaf_time" DisplayMethod="unsigned integer"/>
      <Element Offset="624" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000270" Description="outfit_type_" DisplayMethod="unsigned integer"/>
      <Element Offset="628" Vartype="4 Bytes" Bytesize="4" OffsetHex="00000274" Description="jamming_count" DisplayMethod="unsigned integer"/>
    </Elements>
  </Structure>
</Structures>