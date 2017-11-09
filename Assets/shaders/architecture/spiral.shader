// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:Dissolve,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:32719,y:32712,varname:node_2865,prsc:2|emission-9541-OUT,clip-3363-R;n:type:ShaderForge.SFN_Tex2d,id:3363,x:31785,y:32631,ptovrint:False,ptlb:tex,ptin:_tex,varname:_MainTex_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:48f3301fb1a2c4249acb2c57d443e75b,ntxv:0,isnm:False|UVIN-6741-OUT;n:type:ShaderForge.SFN_Multiply,id:9541,x:32045,y:32823,varname:node_9541,prsc:2|A-3363-RGB,B-7068-RGB,C-2831-RGB,D-4683-OUT;n:type:ShaderForge.SFN_VertexColor,id:7068,x:31785,y:32802,varname:node_7068,prsc:2;n:type:ShaderForge.SFN_Color,id:2831,x:31785,y:32960,ptovrint:True,ptlb:color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4906187,c2:0.625,c3:0.3814338,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:2351,x:30202,y:33381,ptovrint:False,ptlb:u speed,ptin:_uspeed,varname:_uspeed_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:1816,x:30202,y:33465,ptovrint:False,ptlb:v speed,ptin:_vspeed,varname:_vspeed_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Append,id:8630,x:30430,y:33381,varname:node_8630,prsc:2|A-2351-OUT,B-1816-OUT;n:type:ShaderForge.SFN_Time,id:6446,x:30430,y:33547,varname:node_6446,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6190,x:30661,y:33381,varname:node_6190,prsc:2|A-8630-OUT,B-6446-T;n:type:ShaderForge.SFN_Add,id:9705,x:30884,y:33381,varname:node_9705,prsc:2|A-6190-OUT,B-8114-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:8114,x:30661,y:33547,varname:node_8114,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:8770,x:31082,y:33381,varname:node_6429,prsc:2,tex:bef694b9e1e3204479c194bf53a964ea,ntxv:0,isnm:False|UVIN-9705-OUT,TEX-2795-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:2795,x:30884,y:33547,ptovrint:False,ptlb:texture,ptin:_texture,varname:_node_9419_copy_copy_copy,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bef694b9e1e3204479c194bf53a964ea,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Append,id:8781,x:30430,y:33707,varname:node_8781,prsc:2|A-2857-OUT,B-4888-OUT;n:type:ShaderForge.SFN_Time,id:5893,x:30430,y:33873,varname:node_5893,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9416,x:30661,y:33707,varname:node_9416,prsc:2|A-8781-OUT,B-5893-T;n:type:ShaderForge.SFN_TexCoord,id:2935,x:30661,y:33873,varname:node_2935,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:9018,x:30873,y:33707,varname:node_9018,prsc:2|A-9416-OUT,B-2935-UVOUT;n:type:ShaderForge.SFN_Slider,id:5990,x:30504,y:33227,ptovrint:False,ptlb:Dissolve,ptin:_Dissolve,varname:_Dissolve_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.2866498,max:1;n:type:ShaderForge.SFN_OneMinus,id:4157,x:30867,y:33215,varname:node_4157,prsc:2|IN-5990-OUT;n:type:ShaderForge.SFN_RemapRange,id:3962,x:31082,y:33215,varname:node_3962,prsc:2,frmn:0,frmx:1,tomn:-0.5,tomx:0.5|IN-4157-OUT;n:type:ShaderForge.SFN_Add,id:5642,x:31295,y:33381,varname:node_5642,prsc:2|A-3962-OUT,B-8770-B;n:type:ShaderForge.SFN_Add,id:2813,x:31295,y:33562,varname:node_2813,prsc:2|A-3962-OUT,B-7654-B;n:type:ShaderForge.SFN_Multiply,id:7946,x:31502,y:33474,varname:node_7946,prsc:2|A-5642-OUT,B-2813-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2857,x:30181,y:33673,ptovrint:False,ptlb:uu speed,ptin:_uuspeed,varname:_node_2889_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_ValueProperty,id:4888,x:30150,y:33787,ptovrint:False,ptlb:vv speed,ptin:_vvspeed,varname:_node_5408_copy_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.2;n:type:ShaderForge.SFN_Tex2d,id:7654,x:31096,y:33679,varname:node_2807,prsc:2,tex:bef694b9e1e3204479c194bf53a964ea,ntxv:0,isnm:False|UVIN-9018-OUT,TEX-2795-TEX;n:type:ShaderForge.SFN_RemapRange,id:2770,x:31672,y:33474,varname:node_2770,prsc:2,frmn:0,frmx:1,tomn:-5,tomx:5|IN-7946-OUT;n:type:ShaderForge.SFN_Clamp01,id:6118,x:31841,y:33474,varname:node_6118,prsc:2|IN-2770-OUT;n:type:ShaderForge.SFN_OneMinus,id:8911,x:32080,y:33474,varname:node_8911,prsc:2|IN-6118-OUT;n:type:ShaderForge.SFN_Append,id:6741,x:32288,y:33474,varname:node_6741,prsc:2|A-8911-OUT,B-8582-OUT;n:type:ShaderForge.SFN_Vector1,id:8582,x:32098,y:33678,varname:node_8582,prsc:2,v1:2;n:type:ShaderForge.SFN_ValueProperty,id:4683,x:31785,y:33211,ptovrint:False,ptlb:opacity,ptin:_opacity,varname:_opacity_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;proporder:3363-2831-2351-1816-2795-5990-2857-4888-4683;pass:END;sub:END;*/

Shader "Shader Forge/spiral" {
    Properties {
        _tex ("tex", 2D) = "white" {}
        _TintColor ("color", Color) = (0.4906187,0.625,0.3814338,1)
        _uspeed ("u speed", Float ) = 0.1
        _vspeed ("v speed", Float ) = 0.2
        _texture ("texture", 2D) = "white" {}
        _Dissolve ("Dissolve", Range(0, 1)) = 0.2866498
        _uuspeed ("uu speed", Float ) = 0.3
        _vvspeed ("vv speed", Float ) = -0.2
        _opacity ("opacity", Float ) = 3
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _tex; uniform float4 _tex_ST;
            uniform float4 _TintColor;
            uniform float _uspeed;
            uniform float _vspeed;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform float _Dissolve;
            uniform float _uuspeed;
            uniform float _vvspeed;
            uniform float _opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float node_3962 = ((1.0 - _Dissolve)*1.0+-0.5);
                float4 node_6446 = _Time;
                float2 node_9705 = ((float2(_uspeed,_vspeed)*node_6446.g)+i.uv0);
                float4 node_6429 = tex2D(_texture,TRANSFORM_TEX(node_9705, _texture));
                float4 node_5893 = _Time;
                float2 node_9018 = ((float2(_uuspeed,_vvspeed)*node_5893.g)+i.uv0);
                float4 node_2807 = tex2D(_texture,TRANSFORM_TEX(node_9018, _texture));
                float2 node_6741 = float2((1.0 - saturate((((node_3962+node_6429.b)*(node_3962+node_2807.b))*10.0+-5.0))),2.0);
                float4 _tex_var = tex2D(_tex,TRANSFORM_TEX(node_6741, _tex));
                clip(_tex_var.r - 0.5);
////// Lighting:
////// Emissive:
                float3 emissive = (_tex_var.rgb*i.vertexColor.rgb*_TintColor.rgb*_opacity);
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _tex; uniform float4 _tex_ST;
            uniform float _uspeed;
            uniform float _vspeed;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform float _Dissolve;
            uniform float _uuspeed;
            uniform float _vvspeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float node_3962 = ((1.0 - _Dissolve)*1.0+-0.5);
                float4 node_6446 = _Time;
                float2 node_9705 = ((float2(_uspeed,_vspeed)*node_6446.g)+i.uv0);
                float4 node_6429 = tex2D(_texture,TRANSFORM_TEX(node_9705, _texture));
                float4 node_5893 = _Time;
                float2 node_9018 = ((float2(_uuspeed,_vvspeed)*node_5893.g)+i.uv0);
                float4 node_2807 = tex2D(_texture,TRANSFORM_TEX(node_9018, _texture));
                float2 node_6741 = float2((1.0 - saturate((((node_3962+node_6429.b)*(node_3962+node_2807.b))*10.0+-5.0))),2.0);
                float4 _tex_var = tex2D(_tex,TRANSFORM_TEX(node_6741, _tex));
                clip(_tex_var.r - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _tex; uniform float4 _tex_ST;
            uniform float4 _TintColor;
            uniform float _uspeed;
            uniform float _vspeed;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform float _Dissolve;
            uniform float _uuspeed;
            uniform float _vvspeed;
            uniform float _opacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : SV_Target {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float node_3962 = ((1.0 - _Dissolve)*1.0+-0.5);
                float4 node_6446 = _Time;
                float2 node_9705 = ((float2(_uspeed,_vspeed)*node_6446.g)+i.uv0);
                float4 node_6429 = tex2D(_texture,TRANSFORM_TEX(node_9705, _texture));
                float4 node_5893 = _Time;
                float2 node_9018 = ((float2(_uuspeed,_vvspeed)*node_5893.g)+i.uv0);
                float4 node_2807 = tex2D(_texture,TRANSFORM_TEX(node_9018, _texture));
                float2 node_6741 = float2((1.0 - saturate((((node_3962+node_6429.b)*(node_3962+node_2807.b))*10.0+-5.0))),2.0);
                float4 _tex_var = tex2D(_tex,TRANSFORM_TEX(node_6741, _tex));
                o.Emission = (_tex_var.rgb*i.vertexColor.rgb*_TintColor.rgb*_opacity);
                
                float3 diffColor = float3(0,0,0);
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, 0, specColor, specularMonochrome );
                o.Albedo = diffColor;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Dissolve"
    CustomEditor "ShaderForgeMaterialInspector"
}
