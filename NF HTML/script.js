const nfForm = document.getElementById('nfForm');

nfForm.addEventListener('submit', function(event) {
    event.preventDefault();
    const valor = parseFloat(document.getElementById('valor').value);
    calcularImpostos(valor);
});

function calcularImpostos(valor) {
    const pis = Math.round((valor * 0.0065) * 100) / 100;
    const cofins = Math.round((valor * 0.03) * 100) / 100;
    const csll = Math.round((valor * 0.01) * 100) / 100;
    const ir = Math.round((valor * 0.015) * 100) / 100;
    
    const totalSocial = pis + cofins + csll;
    
    document.getElementById('resPis').textContent = pis.toFixed(2).replace('.', ',');
    document.getElementById('resCofins').textContent = cofins.toFixed(2).replace('.', ',');
    document.getElementById('resCsll').textContent = csll.toFixed(2).replace('.', ',');
    document.getElementById('resIr').textContent = ir.toFixed(2).replace('.', ',');
    document.getElementById('resTotal').textContent = totalSocial.toFixed(2).replace('.', ',');
}