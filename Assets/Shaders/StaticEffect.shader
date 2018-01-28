// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/StaticEffect" {
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
	_Radius("Radius", Range(0.001, 500)) = 10
	}
		SubShader
	{
		Tags{ "Queue" = "Transparent" "RenderType" = "Transparent" }

		Blend SrcAlpha OneMinusSrcAlpha

		Pass
	{
		CGPROGRAM
#pragma vertex vert
#pragma fragment frag
#include "UnityCG.cginc"

		struct v2f {
		float4 pos : SV_POSITION;
		float2 uv : TEXCOORD0;
		float4 worldPos : TEXCOORD1;
		float3 objectPos : TEXCOORD2;
	};

	sampler2D _MainTex;
	float4 _MainTex_ST;

	v2f vert(appdata_base v) {
		v2f o;
		o.pos = UnityObjectToClipPos(v.vertex);
		o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
		o.worldPos = mul(unity_ObjectToWorld, v.vertex);
		o.objectPos = v.vertex.xyz;
		return o;
	}

	float _Radius;

	float triWave(float t, float offset, float yOffset)
	{

		return saturate(abs(frac(t - offset) * 9  + .3) - yOffset);
		//return saturate(abs(frac(offset + t) * 2 - 1)  - yOffset);
	}

	fixed4 texColor(v2f i)
	{
		fixed4 mainTex = tex2D(_MainTex, i.uv);
		//mainTex.a = .2f;
		//mainTex.r *= triWave(_Time.y *.2, i.objectPos.y), -0.7) * 6;
		mainTex.r *= triWave(_Time.x * 3.0f, i.objectPos.y ,i.objectPos.x) * .8f;
	return mainTex.r;

	}


	fixed4 frag(v2f i) : SV_Target
	{
	
		

	//float dist = distance(i.worldPos, _WorldSpaceCameraPos);

	fixed4 texWave = texColor(i);
	fixed4 col = texWave;
	if(_Radius <= 20.0f && _Radius >= 12.0f)
	{
		_Radius += 1.0f;
		col.a = saturate(1.0f / _Radius);
	}
	else
	{
		_Radius -= 1.0f;
		col.a = saturate(1.0f / _Radius);

	}
	return col;
	}

		ENDCG
	}
	}
}
