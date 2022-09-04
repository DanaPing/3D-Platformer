Shader "GAD210/4_Diffuse Extrude" 
{
    
    Properties
    {
        //Students 1
        _Colour("Colour", Color) = (1, 1, 1, 1) //RGBA
        _MainTex("Texture", 2D) = "white" {}
        _Amount("Puffy", Range(-0.1, 0.1)) = 0
    }

    SubShader 
	{
      Tags { "RenderType" = "Opaque" }
      CGPROGRAM
      #pragma surface surf Lambert vertex:vert

      //variables here
      half4 _Colour;
      sampler2D _MainTex;
      float _Amount;

      struct Input {
          float4 color : COLOR;
          float2 uv_MainTex;
          float3 worldPos; //Magic
          float4 screenPos; //Magic
          float3 viewDir;
      };

      void vert(inout appdata_full v)
      {
          //change vertex data here
      }

      void surf (Input IN, inout SurfaceOutput o) 
      {
        //o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb * _Colour;
      }
      ENDCG
    }
    Fallback "Diffuse"
}
