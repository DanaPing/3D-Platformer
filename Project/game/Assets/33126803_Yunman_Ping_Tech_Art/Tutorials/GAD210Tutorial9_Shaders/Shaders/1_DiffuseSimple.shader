Shader "GAD210/1_Diffuse Simple" 
{

    SubShader 
	{
      Tags { "RenderType" = "Opaque" }
      CGPROGRAM
      #pragma surface surf Lambert

      //variables here
      half4 _Colour;
    

      struct Input {
          float4 color : COLOR;
        
      };
      void surf (Input IN, inout SurfaceOutput o) 
      {
          //o.Albedo = 1; // 1 = (1,1,1,1) = white
          //o.Albedo.rgb = fixed3(1, 0, 0); //Red
          //o.Albedo.rgb = fixed3(0, 1, 0); //Green
          //o.Albedo.rgb = fixed3(0, 0, 1); //Blue
      }
      ENDCG
    }
    Fallback "Diffuse"
}
