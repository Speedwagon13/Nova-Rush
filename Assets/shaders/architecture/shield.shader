// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:Dissolve,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:32724,y:32693,varname:node_4795,prsc:2|emission-2393-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:32235,y:32601,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:48f3301fb1a2c4249acb2c57d443e75b,ntxv:0,isnm:False|UVIN-363-OUT;n:type:ShaderForge.SFN_Multiply,id:2393,x:32495,y:32793,varname:node_2393,prsc:2|A-6074-RGB,B-2053-RGB,C-797-RGB,D-9313-OUT;n:type:ShaderForge.SFN_VertexColor,id:2053,x:32235,y:32772,varname:node_2053,prsc:2;n:type:ShaderForge.SFN_Color,id:797,x:32235,y:32930,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:5658,x:30652,y:33351,ptovrint:False,ptlb:u speed_copy,ptin:_uspeed_copy,varname:_uspeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:4079,x:30652,y:33435,ptovrint:False,ptlb:v speed_copy,ptin:_vspeed_copy,varname:_vspeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Append,id:5768,x:30880,y:33351,varname:node_5768,prsc:2|A-5658-OUT,B-4079-OUT;n:type:ShaderForge.SFN_Time,id:2571,x:30880,y:33517,varname:node_2571,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5585,x:31111,y:33351,varname:node_5585,prsc:2|A-5768-OUT,B-2571-T;n:type:ShaderForge.SFN_Add,id:317,x:31334,y:33351,varname:node_317,prsc:2|A-5585-OUT,B-3015-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:3015,x:31111,y:33517,varname:node_3015,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:6361,x:31532,y:33351,varname:node_6429,prsc:2,tex:bef694b9e1e3204479c194bf53a964ea,ntxv:0,isnm:False|UVIN-317-OUT,TEX-4034-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:4034,x:31334,y:33517,ptovrint:False,ptlb:node_9419_copy,ptin:_node_9419_copy,varname:_node_9419_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bef694b9e1e3204479c194bf53a964ea,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Append,id:7750,x:30880,y:33677,varname:node_7750,prsc:2|A-7817-OUT,B-7644-OUT;n:type:ShaderForge.SFN_Time,id:6802,x:30880,y:33843,varname:node_6802,prsc:2;n:type:ShaderForge.SFN_Multiply,id:5468,x:31111,y:33677,varname:node_5468,prsc:2|A-7750-OUT,B-6802-T;n:type:ShaderForge.SFN_TexCoord,id:5358,x:31111,y:33843,varname:node_5358,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:4690,x:31323,y:33677,varname:node_4690,prsc:2|A-5468-OUT,B-5358-UVOUT;n:type:ShaderForge.SFN_Slider,id:6866,x:30954,y:33197,ptovrint:False,ptlb:Dissolve_copy,ptin:_Dissolve_copy,varname:_Dissolve_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2866498,max:1;n:type:ShaderForge.SFN_OneMinus,id:9262,x:31317,y:33185,varname:node_9262,prsc:2|IN-6866-OUT;n:type:ShaderForge.SFN_RemapRange,id:9858,x:31532,y:33185,varname:node_9858,prsc:2,frmn:0,frmx:1,tomn:-0.5,tomx:0.5|IN-9262-OUT;n:type:ShaderForge.SFN_Add,id:3761,x:31745,y:33351,varname:node_3761,prsc:2|A-9858-OUT,B-6361-B;n:type:ShaderForge.SFN_Add,id:1238,x:31745,y:33532,varname:node_1238,prsc:2|A-9858-OUT,B-3074-B;n:type:ShaderForge.SFN_Multiply,id:572,x:31952,y:33444,varname:node_572,prsc:2|A-3761-OUT,B-1238-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7817,x:30631,y:33643,ptovrint:False,ptlb:node_2889_copy,ptin:_node_2889_copy,varname:_node_2889_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_ValueProperty,id:7644,x:30600,y:33757,ptovrint:False,ptlb:node_5408_copy,ptin:_node_5408_copy,varname:_node_5408_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.2;n:type:ShaderForge.SFN_Tex2d,id:3074,x:31546,y:33649,varname:node_2807,prsc:2,tex:bef694b9e1e3204479c194bf53a964ea,ntxv:0,isnm:False|UVIN-4690-OUT,TEX-4034-TEX;n:type:ShaderForge.SFN_RemapRange,id:5978,x:32122,y:33444,varname:node_5978,prsc:2,frmn:0,frmx:1,tomn:-10,tomx:10|IN-572-OUT;n:type:ShaderForge.SFN_Clamp01,id:4244,x:32291,y:33444,varname:node_4244,prsc:2|IN-5978-OUT;n:type:ShaderForge.SFN_OneMinus,id:690,x:32530,y:33444,varname:node_690,prsc:2|IN-4244-OUT;n:type:ShaderForge.SFN_Append,id:363,x:32738,y:33444,varname:node_363,prsc:2|A-690-OUT,B-5944-OUT;n:type:ShaderForge.SFN_Vector1,id:5944,x:32548,y:33648,varname:node_5944,prsc:2,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9313,x:32235,y:33181,ptovrint:False,ptlb:opacity,ptin:_opacity,varname:node_9313,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;proporder:6074-797-5658-4079-4034-6866-7817-7644-9313;pass:END;sub:END;*/

Shader "Shader Forge/shield" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _TintColor ("Color", Color) = (0.5,0.5,0.5,1)
        _uspeed_copy ("u speed_copy", Float ) = 0.1
        _vspeed_copy ("v speed_copy", Float ) = 0.2
        _node_9419_copy ("node_9419_copy", 2D) = "white" {}
        _Dissolve_copy ("Dissolve_copy", Range(0, 1)) = 0.2866498
        _node_2889_copy ("node_2889_copy", Float ) = 0.3
        _node_5408_copy ("node_5408_copy", Float ) = -0.2
        _opacity ("opacity", Float ) = 2
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles metal 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _TintColor;
            uniform float _uspeed_copy;
            uniform float _vspeed_copy;
            uniform sampler2D _node_9419_copy; uniform float4 _node_9419_copy_ST;
            uniform float _Dissolve_copy;
            uniform float _node_2889_copy;
            uniform float _node_5408_copy;
            uniform float _opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float node_9858 = ((1.0 - _Dissolve_copy)*1.0+-0.5);
                float4 node_2571 = _Time;
                float2 node_317 = ((float2(_uspeed_copy,_vspeed_copy)*node_2571.g)+i.uv0);
                float4 node_6429 = tex2D(_node_9419_copy,TRANSFORM_TEX(node_317, _node_9419_copy));
                float4 node_6802 = _Time;
                float2 node_4690 = ((float2(_node_2889_copy,_node_5408_copy)*node_6802.g)+i.uv0);
                float4 node_2807 = tex2D(_node_9419_copy,TRANSFORM_TEX(node_4690, _node_9419_copy));
                float2 node_363 = float2((1.0 - saturate((((node_9858+node_6429.b)*(node_9858+node_2807.b))*20.0+-10.0))),0.0);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_363, _MainTex));
                float3 emissive = (_MainTex_var.rgb*i.vertexColor.rgb*_TintColor.rgb*_opacity);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0.5,0.5,0.5,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
