namespace TypingSpeed;

public class TextGenerator
{
    public List<string> textlist = new List<string>
    {
        "Ini adalah tes kecepatan mengetik. Ketik teks ini secepat mungkin!",
        "Tulis teks ini dengan cepat dan akurat!",
        "Kecepatan mengetik adalah keterampilan yang penting dalam dunia digital.",
        "Latihan membuat sempurna. Terus tingkatkan kecepatan mengetikmu!",
        "Berusahalah mencapai kecepatan mengetik yang lebih tinggi setiap harinya!"
    };

    public static int CalculateTypingScore(int charactersTyped, double typingSpeed)
    {
        // Menggunakan rumus sederhana untuk menghitung skor mengetik berdasarkan jumlah karakter dan kecepatan mengetik
        int score = (int)(charactersTyped * typingSpeed / 1000);
        return score;
    }

    public string GetRandomText()
    {
        Random random = new Random();
        int index = random.Next(0, textlist.Count);
        return textlist[index];
    }
}
