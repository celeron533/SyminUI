
sampler2D inputTex : register(S0);
float2 center : register(C0);
float4 color1 : register(C1);
float4 color2: register(C2);
float2 range : register(C3);

static const float PI = 3.14159265f;

float4 main(float2 uv : TEXCOORD) : COLOR
{
    //UI��͸��ͨ��
    float alpha = tex2D(inputTex, uv).a;
    //��üнǻ���
    float angle = atan2(uv.y - center.y, uv.x - center.x) + PI;
    //ת��Ϊ 0~1 ��Χ
    angle = (angle / (2 * PI));
    //��ȡ��Χ����
    float rangeWidth = range.y - range.x;
    //���ݷ�Χ�ض�
    angle = max(range.x, angle);
    angle = min(range.y, angle);

    float rangeRatio = (angle - range.x) / rangeWidth;

    float4 color = lerp(color1, color2, rangeRatio) * alpha;

    

    return float4(color.xyz, alpha);
}