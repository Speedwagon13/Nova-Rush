// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:32724,y:32693,varname:node_4795,prsc:2|emission-8357-OUT;n:type:ShaderForge.SFN_Tex2d,id:9162,x:32258,y:32729,ptovrint:False,ptlb:base turbulence,ptin:_baseturbulence,varname:node_9162,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ddfc209e498d69943976a4454e3d790e,ntxv:0,isnm:False|UVIN-7295-OUT;n:type:ShaderForge.SFN_Add,id:7295,x:32042,y:32729,varname:node_7295,prsc:2|A-7345-OUT,B-5858-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:5858,x:31827,y:32946,varname:node_5858,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:7345,x:31843,y:32586,varname:node_7345,prsc:2|A-2188-OUT,B-9748-OUT;n:type:ShaderForge.SFN_ComponentMask,id:2188,x:31604,y:32565,varname:node_2188,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-4989-RGB;n:type:ShaderForge.SFN_ScreenPos,id:311,x:30985,y:32534,varname:node_311,prsc:2,sctp:0;n:type:ShaderForge.SFN_Multiply,id:1249,x:31250,y:32626,varname:node_1249,prsc:2|A-311-UVOUT,B-765-OUT;n:type:ShaderForge.SFN_ValueProperty,id:765,x:30967,y:32804,ptovrint:False,ptlb:tiling size,ptin:_tilingsize,varname:node_765,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Tex2d,id:4989,x:31439,y:32762,ptovrint:False,ptlb:node_4989,ptin:_node_4989,varname:node_4989,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ddfc209e498d69943976a4454e3d790e,ntxv:0,isnm:False|UVIN-1249-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9748,x:31700,y:32863,ptovrint:False,ptlb:intensity,ptin:_intensity,varname:node_9748,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:450,x:32509,y:32868,varname:node_450,prsc:2|A-9162-RGB,B-283-RGB;n:type:ShaderForge.SFN_Tex2d,id:283,x:32289,y:32973,ptovrint:False,ptlb:distort,ptin:_distort,varname:node_283,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:81d78795b575cd54397d8a263a584e80,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:8357,x:32524,y:33123,varname:node_8357,prsc:2|A-450-OUT,B-8785-RGB;n:type:ShaderForge.SFN_VertexColor,id:8785,x:32439,y:33335,varname:node_8785,prsc:2;proporder:9162-765-4989-9748-283;pass:END;sub:END;*/

Shader "Shader Forge/fire" {
    Properties {
        _baseturbulence ("base turbulence", 2D) = "white" {}
        _tilingsize ("tiling size", Float ) = 0.1
        _node_4989 ("node_4989", 2D) = "white" {}
        _intensity ("intensity", Float ) = 0.2
        _distort ("distort", 2D) = "white" {}
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
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _baseturbulence; uniform float4 _baseturbulence_ST;
            uniform float _tilingsize;
            uniform sampler2D _node_4989; uniform float4 _node_4989_ST;
            uniform float _intensity;
            uniform sampler2D _distort; uniform float4 _distort_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD1;
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
////// Lighting:
////// Emissive:
                float2 node_1249 = ((sceneUVs * 2 - 1).rg*_tilingsize);
                float4 _node_4989_var = tex2D(_node_4989,TRANSFORM_TEX(node_1249, _node_4989));
                float2 node_7295 = ((_node_4989_var.rgb.rg*_intensity)+i.uv0);
                float4 _baseturbulence_var = tex2D(_baseturbulence,TRANSFORM_TEX(node_7295, _baseturbulence));
                float4 _distort_var = tex2D(_distort,TRANSFORM_TEX(i.uv0, _distort));
                float3 emissive = ((_baseturbulence_var.rgb*_distort_var.rgb)*i.vertexColor.rgb);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0,0,0,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
