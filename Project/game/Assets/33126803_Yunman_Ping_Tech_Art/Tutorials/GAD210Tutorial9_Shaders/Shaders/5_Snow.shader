// Upgrade NOTE: replaced '_World2Object' with 'unity_WorldToObject'

Shader "GAD210/5_Snow" 
{
    
    Properties
    {
        //Students 1
        _Colour("Colour", Color) = (1, 1, 1, 1) //RGBA
        _MainTex("Texture", 2D) = "white" {}
        _Normal("Normal Map", 2D) = "bump" {}
        _Snow("Snow Level", Range(1, -1)) = 1
        _SnowColour("Snow Colour", Color) = (1, 1, 1, 1)
        _SnowDirection("Snow Direction", Vector) = (0, 1, 0)
        _SnowDepth("Snow Depth", Range(0, -0.1)) = 0

    }

    SubShader 
	{
      Tags { "RenderType" = "Opaque" }
      LOD 200
      CGPROGRAM
      #pragma surface surf Lambert vertex:vert

      //variables here
      half4 _Colour;
      sampler2D _MainTex;
      sampler2D _Normal;
      float _Snow;
      float4 _SnowColour;
      float4 _MainColour;
      float4 _SnowDirection;
      float _SnowDepth;

      struct Input {
          float4 color : COLOR;
          float2 uv_MainTex;
          float2 uv_Normal;
          float4 worldNormal;
          INTERNAL_DATA
      };

      void vert(inout appdata_full v)
      { 
          //convert snow direction from world space to object space
          
          float4 sn = mul(_SnowDirection, unity_WorldToObject);

          //if the dot of v.normal and sn.xyz is greater than or equal to _Snow:
          //xyz of v.vertex should have added to it:
          //    (sn.xyz plus the vertex normal) times snowdeoth * snow

      }

      void surf (Input IN, inout SurfaceOutput o) 
      {
          half4 c = tex2D(_MainTex, IN.uv_MainTex); //tex colour
          o.Normal = UnpackNormal(tex2D(_Normal, IN.uv_Normal));
          
          //use snowcolour if the dot of (WorldNormalVector(IN, o.Normal) and Snowdirection.xyz is >= _Snow.
          //Otherwise use c rgb * _Colour
      
          o.Alpha = 1;
      }
      ENDCG
    }
    Fallback "Diffuse"
}
