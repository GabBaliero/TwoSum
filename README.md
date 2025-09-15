# TwoSum
Disciplina DevOps PUCPR

O **Two Sum** é um problema clássico de programação: dado um array de números e um valor alvo (target), você precisa encontrar dois números no array cuja soma seja igual ao alvo e retornar os índices desses números ou seus dois números que somados resultam no target.

# Como funciona a solução mais eficiente:

1. Criado um dicionário para armazenar os números que já lidos nos índices.

2. Iteramos pelo array:

   - Para cada número num, calculamos o complemento target - num.

   - Verificamos se esse complemento já está no dicionário:

   - Se sim, encontramos o par e retornamos os índices.

   - Se não, adicionamos o número atual ao dicionário.

3. Se chegarmos ao fim sem encontrar par, retornamos **null**.

Essa abordagem tem complexidade **O(n)**, porque percorre o array apenas uma vez.
