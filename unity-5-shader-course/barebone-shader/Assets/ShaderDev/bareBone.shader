Shader "ShaderDev/BareBone"
{
    Properties
    {
        _Color("Main Color", Color) = (1, 1, 1, 1)
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            uniform half4 _Color;

            struct vertexInput
            {
                float4 vertex : POSITION;
            };

            struct vertextOutput
            {
                float4 pos : SV_POSITION;
            };

            vertextOutput vert(vertexInput v)
            {
                vertextOutput o;

                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);

                return o;
            }

            half4 frag(vertextOutput i) : COLOR
            {
                return _Color;
            }

            ENDCG


        }


    }
}
