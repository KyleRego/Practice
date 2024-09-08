import org.junit.Test;
import static org.junit.Assert.*;

public class MyClassTest {

    @Test
    public void testAdd() {
        MyClass myClass = new MyClass();
        assertEquals(5, myClass.add(2, 3));
    }
}
