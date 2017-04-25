Shader "Camera/Beer"
{
	Properties
	{
		_NoiseTex("TextureNoise", 2D) = "white" {}
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			sampler2D _MainTex;
			sampler2D _NoiseTex;

			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.uv);
				
				float2 randNum = float2(sin(_Time[1]), sin(_Time[1]));
				fixed4 randColor = tex2D(_NoiseTex, randNum);

				if (col.r < 0.55)
					col = randColor;
				if (col.b > 0.55)
					col = randColor.b;
				
				if (col.g > 0.65)
					col.b = 0.91;
				if (col.r < 0.7)
					col.g = 0;
						
				return col;
			}
			ENDCG
		}
	}
}
