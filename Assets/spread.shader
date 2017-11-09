// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:32719,y:32712,varname:node_4013,prsc:2|diff-4972-RGB,emission-6424-OUT;n:type:ShaderForge.SFN_Tex2d,id:4972,x:32319,y:32674,ptovrint:False,ptlb:texture,ptin:_texture,varname:node_4972,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c397ecc1a35624e7b92465cbdef81358,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:6826,x:32106,y:32828,ptovrint:False,ptlb:emissive map,ptin:_emissivemap,varname:node_6826,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:07d534e4a85484570adf991e51bef34c,ntxv:0,isnm:False;n:type:ShaderForge.SFN_ChannelBlend,id:3703,x:32446,y:32996,varname:node_3703,prsc:2,chbt:0|M-6826-RGB,R-7714-RGB,G-3612-RGB,B-4642-OUT;n:type:ShaderForge.SFN_Color,id:7714,x:32106,y:33032,ptovrint:False,ptlb:Shoot Col,ptin:_ShootCol,varname:node_7714,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9926471,c2:0.7329077,c3:0.05109212,c4:1;n:type:ShaderForge.SFN_Color,id:3612,x:32106,y:33215,ptovrint:False,ptlb:Eye Col,ptin:_EyeCol,varname:node_3612,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.04930795,c2:0.8382353,c3:0.3485563,c4:1;n:type:ShaderForge.SFN_Vector3,id:4642,x:32297,y:33256,varname:node_4642,prsc:2,v1:0,v2:0,v3:0;n:type:ShaderForge.SFN_Multiply,id:5222,x:33224,y:32780,varname:node_5222,prsc:2|A-6294-RGB,B-1508-RGB;n:type:ShaderForge.SFN_Color,id:1508,x:33031,y:32873,ptovrint:False,ptlb:Color_copy,ptin:_Color_copy,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5019608,c2:0.5019608,c3:0.5019608,c4:1;n:type:ShaderForge.SFN_Tex2d,id:6294,x:33031,y:32688,ptovrint:True,ptlb:Base Color_copy,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:4483,x:33517,y:33046,ptovrint:True,ptlb:Normal Map_copy,ptin:_BumpMap,varname:_BumpMap,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Slider,id:3029,x:33360,y:32848,ptovrint:False,ptlb:Metallic_copy,ptin:_Metallic_copy,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:1975,x:33360,y:32950,ptovrint:False,ptlb:Gloss_copy,ptin:_Gloss_copy,varname:_Gloss_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_Tex2d,id:278,x:33170,y:32360,ptovrint:False,ptlb:emissive_copy,ptin:_emissive_copy,varname:_emissive_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:adc849ec251918a41aeffe446248a80f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:9987,x:33370,y:32456,varname:node_9987,prsc:2|A-278-RGB,B-4014-RGB;n:type:ShaderForge.SFN_Color,id:4014,x:33170,y:32559,ptovrint:False,ptlb:emissive color_copy,ptin:_emissivecolor_copy,varname:_emissivecolor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9044118,c2:0.4826587,c3:0.09975129,c4:1;n:type:ShaderForge.SFN_Multiply,id:8312,x:33589,y:32609,varname:node_8312,prsc:2|A-9987-OUT,B-2129-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2129,x:33358,y:32708,ptovrint:False,ptlb:emissive mag_copy,ptin:_emissivemag_copy,varname:_emissivemag_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Multiply,id:6424,x:32564,y:32477,varname:node_6424,prsc:2|A-3703-OUT,B-8893-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8893,x:32333,y:32576,ptovrint:False,ptlb:emissive mag_copy_copy,ptin:_emissivemag_copy_copy,varname:_emissivemag_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;proporder:6826-7714-3612-4972-8893;pass:END;sub:END;*/

Shader "Shader Forge/spread" {
    Properties {
        _emissivemap ("emissive map", 2D) = "white" {}
        _ShootCol ("Shoot Col", Color) = (0.9926471,0.7329077,0.05109212,1)
        _EyeCol ("Eye Col", Color) = (0.04930795,0.8382353,0.3485563,1)
        _texture ("texture", 2D) = "white" {}
        _emissivemag_copy_copy ("emissive mag_copy_copy", Float ) = 2
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform sampler2D _emissivemap; uniform float4 _emissivemap_ST;
            uniform float4 _ShootCol;
            uniform float4 _EyeCol;
            uniform float _emissivemag_copy_copy;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _texture_var = tex2D(_texture,TRANSFORM_TEX(i.uv0, _texture));
                float3 diffuseColor = _texture_var.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _emissivemap_var = tex2D(_emissivemap,TRANSFORM_TEX(i.uv0, _emissivemap));
                float3 emissive = ((_emissivemap_var.rgb.r*_ShootCol.rgb + _emissivemap_var.rgb.g*_EyeCol.rgb + _emissivemap_var.rgb.b*float3(0,0,0))*_emissivemag_copy_copy);
/// Final Color:
                float3 finalColor = diffuse + emissive;
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
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _texture; uniform float4 _texture_ST;
            uniform sampler2D _emissivemap; uniform float4 _emissivemap_ST;
            uniform float4 _ShootCol;
            uniform float4 _EyeCol;
            uniform float _emissivemag_copy_copy;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 _texture_var = tex2D(_texture,TRANSFORM_TEX(i.uv0, _texture));
                float3 diffuseColor = _texture_var.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
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
