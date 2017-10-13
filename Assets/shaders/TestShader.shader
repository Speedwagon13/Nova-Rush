// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33209,y:32712,varname:node_9361,prsc:2|custl-4096-OUT;n:type:ShaderForge.SFN_Blend,id:7672,x:32619,y:33172,varname:node_7672,prsc:2,blmd:10,clmp:True|SRC-4919-RGB,DST-3797-RGB;n:type:ShaderForge.SFN_Lerp,id:8682,x:32641,y:32829,varname:node_8682,prsc:2|A-4919-RGB,B-5312-XYZ,T-6620-OUT;n:type:ShaderForge.SFN_Vector4Property,id:5312,x:32390,y:32807,ptovrint:False,ptlb:node_5312,ptin:_node_5312,varname:node_5312,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5,v2:0.5,v3:0.5,v4:1;n:type:ShaderForge.SFN_OneMinus,id:6620,x:32390,y:32958,varname:node_6620,prsc:2|IN-3277-OUT;n:type:ShaderForge.SFN_Multiply,id:3277,x:32207,y:32958,varname:node_3277,prsc:2|A-4897-OUT,B-2615-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2615,x:32025,y:33112,ptovrint:False,ptlb:node_2615,ptin:_node_2615,varname:node_2615,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_OneMinus,id:4897,x:32025,y:32958,varname:node_4897,prsc:2|IN-7737-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:7737,x:31843,y:32958,varname:node_7737,prsc:2;n:type:ShaderForge.SFN_Color,id:3797,x:32025,y:33220,ptovrint:False,ptlb:diffuse,ptin:_diffuse,varname:node_3797,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9558824,c2:0.856998,c3:0.5974265,c4:1;n:type:ShaderForge.SFN_Multiply,id:9892,x:32863,y:33322,varname:node_9892,prsc:2|A-3797-RGB,B-1213-RGB;n:type:ShaderForge.SFN_LightColor,id:1213,x:32133,y:33535,varname:node_1213,prsc:2;n:type:ShaderForge.SFN_Blend,id:4096,x:32914,y:32833,varname:node_4096,prsc:2,blmd:10,clmp:True|SRC-8682-OUT,DST-9892-OUT;n:type:ShaderForge.SFN_Color,id:4919,x:32385,y:32642,ptovrint:False,ptlb:Shadow Color,ptin:_ShadowColor,varname:node_4919,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8823529,c2:0.1297578,c3:0.1297578,c4:1;proporder:5312-2615-3797-4919;pass:END;sub:END;*/

Shader "Shader Forge/TestShader" {
    Properties {
        _node_5312 ("node_5312", Vector) = (0.5,0.5,0.5,1)
        _node_2615 ("node_2615", Float ) = 10
        _diffuse ("diffuse", Color) = (0.9558824,0.856998,0.5974265,1)
        _ShadowColor ("Shadow Color", Color) = (0.8823529,0.1297578,0.1297578,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _node_5312;
            uniform float _node_2615;
            uniform float4 _diffuse;
            uniform float4 _ShadowColor;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                LIGHTING_COORDS(0,1)
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 finalColor = saturate(( (_diffuse.rgb*_LightColor0.rgb) > 0.5 ? (1.0-(1.0-2.0*((_diffuse.rgb*_LightColor0.rgb)-0.5))*(1.0-lerp(_ShadowColor.rgb,_node_5312.rgb,(1.0 - ((1.0 - attenuation)*_node_2615))))) : (2.0*(_diffuse.rgb*_LightColor0.rgb)*lerp(_ShadowColor.rgb,_node_5312.rgb,(1.0 - ((1.0 - attenuation)*_node_2615)))) ));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _node_5312;
            uniform float _node_2615;
            uniform float4 _diffuse;
            uniform float4 _ShadowColor;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                LIGHTING_COORDS(0,1)
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 finalColor = saturate(( (_diffuse.rgb*_LightColor0.rgb) > 0.5 ? (1.0-(1.0-2.0*((_diffuse.rgb*_LightColor0.rgb)-0.5))*(1.0-lerp(_ShadowColor.rgb,_node_5312.rgb,(1.0 - ((1.0 - attenuation)*_node_2615))))) : (2.0*(_diffuse.rgb*_LightColor0.rgb)*lerp(_ShadowColor.rgb,_node_5312.rgb,(1.0 - ((1.0 - attenuation)*_node_2615)))) ));
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
