
using FunctionExplorer.Utils;
using MathNet.Symbolics;
using Xunit;

namespace FunctionExplorer.Tests;

public class MathUtilsTests
{
    [Fact]
    public void Arvuta_XRuutKuiXOnKolm_TagastabUheksa()
    {
        var funktsioon = SymbolicExpression.Parse("x^2");

        var tulemus = MathUtils.Arvuta(funktsioon, 3);

        Assert.NotNull(tulemus);
        Assert.Equal(9, tulemus.Value, 6);
    }

    [Fact]
    public void Tuletis_XRuutKuiXOnKolm_TagastabKuus()
    {
        var funktsioon = SymbolicExpression.Parse("x^2");
        var tuletis = MathUtils.Tuletis(funktsioon);

        var tulemus = MathUtils.Arvuta(tuletis, 3);

        Assert.NotNull(tulemus);
        Assert.Equal(6, tulemus.Value, 6);
    }
}
