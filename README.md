# Тестовое задание

Проект при компиляции должен формировать файл-библиотеку с именем lib.dll
Namespace по умолчанию ds.test.impl
При подключении данной библиотеки в данном Namespace должны быть доступны:
IPlugin и один статический класс Plugins:
public interface IPlugin
{
  string PluginName { get; }
  string Version { get; }
  System.Drawing.Image Image { get; }
  string Description { get; }
  int Run (int input1, int input2);
}

Статический класс Plugins должен реализовывать интерфейс:
interface PluginFactory
{
  int PluginsCount { get; }
  string[] GetPluginNames { get; }
  IPlugin GetPlugin (string pluginName);
}

Часть реализаций интерфейса IPlugin должна быть унаследована от закрытого абстрактного класса/
Метод Run должен реализовывать различные математические функции (сложение умножение и т.п. их количество зависит от Вашего желания помочь экипажу)
Библиотека должна работать стабильно, должны быть реализованы все необходимые проверки, должно использоваться документирование, 
так чтобы ни у кого не возникло вопросов как пользоваться данной библиотекой.
В реализации интерфейсов допускается, но не рекомендуется использование сторонних библиотек.

## Комментарии по выполненному заданию
1) Статический класс Plugins не может реализовать интерфейс PluginFactory -> поэтому был сделан обычный класс Plugins, а не статический (Ветка -> [main](https://github.com/Haxend/ds.test.impl))
    - Можно сделать класс PluginManager, который реализовывал бы интерфейс PluginFactory и обращался бы через Plugins например:
    ```C#
    public class PluginManager : PluginFactory
    {
      public int PluginsCount => Plugins.PluginsCount;
      public string[] GetPluginNames => Plugins.GetPluginNames;
      public IPlugin GetPlugin(string pluginName) => Plugins.GetPlugin(pluginName);
    }
    ```
    - Вариант чисто по заданию, но без реализации интерфейса (Ветка -> [Version0](https://github.com/Haxend/ds.test.impl/tree/Version0))
2) Добавил Unit тесты - покрытие не полное (можно до бесконечности различных тестов написать ;) )
